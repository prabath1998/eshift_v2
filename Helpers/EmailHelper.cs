using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailKit.Net.Smtp;
using MailKit.Security; // Added for SecureSocketOptions
using System.IO;
using System.Windows.Forms; // For MessageBox (used cautiously in background)
using System.Collections.Concurrent; // For ConcurrentQueue
using System.Threading; // For CancellationTokenSource

namespace eShift_Logistics_System.Helpers
{
    // --- Email Message Data Structure ---
    /// <summary>
    /// Represents an email message to be sent via the queue.
    /// </summary>
    public class EmailMessage
    {
        public string ToEmail { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public string AttachmentPath { get; set; }
        public bool IsHtml { get; set; }
    }

    public static class EmailHelper
    {       
        private static readonly string emailAddress = "a3748c7f61b26f";
        private static readonly string emailPassword = "f6b67a1e719146";
        private static readonly string smtpHost = "smtp.mailtrap.io";
        private static readonly int smtpPort = 587;

        private static ConcurrentQueue<EmailMessage> _emailQueue = new ConcurrentQueue<EmailMessage>();
        private static CancellationTokenSource _cancellationTokenSource;
        private static Task _emailProcessorTask;
        private static bool _isProcessing = false;
        private static readonly object _processingLock = new object();

        public static void StartEmailQueueProcessor()
        {
            lock (_processingLock)
            {
                if (_isProcessing) return;

                _cancellationTokenSource = new CancellationTokenSource();
                _emailProcessorTask = Task.Run(async () => await ProcessEmailQueueLoop(_cancellationTokenSource.Token));
                _isProcessing = true;
                Console.WriteLine("Email queue processor started.");
            }
        }

        /// <summary>
        /// Stops the background task that processes the email queue.
        /// Call this when your application is shutting down (e.g., in your main form's FormClosing event).
        /// </summary>
        public static void StopEmailQueueProcessor()
        {
            lock (_processingLock)
            {
                if (!_isProcessing) return; // Not running

                _cancellationTokenSource?.Cancel(); // Signal the task to cancel
                try
                {
                    _emailProcessorTask?.Wait(); // Wait for the task to finish gracefully
                }
                catch (AggregateException ex)
                {
                    // Handle TaskCanceledException which is expected when cancellation occurs
                    ex.Handle(e => e is OperationCanceledException);
                }
                finally
                {
                    _cancellationTokenSource?.Dispose();
                    _isProcessing = false;
                    Console.WriteLine("Email queue processor stopped.");
                }
            }
        }

        /// <summary>
        /// The main background loop that processes emails from the queue.
        /// </summary>
        private static async Task ProcessEmailQueueLoop(CancellationToken cancellationToken)
        {
            while (!cancellationToken.IsCancellationRequested)
            {
                if (_emailQueue.TryDequeue(out EmailMessage emailToSend))
                {
                    // An email is available, try to send it
                    await ProcessAndSendEmail(emailToSend, cancellationToken);
                }
                else
                {
                    // No emails in queue, wait for a short period before checking again
                    try
                    {
                        await Task.Delay(1000, cancellationToken); // Wait 1 second
                    }
                    catch (OperationCanceledException)
                    {
                        // Expected if cancellation is requested during the delay
                        break;
                    }
                }
            }
            Console.WriteLine("Email queue processor finished its loop.");
        }

        /// <summary>
        /// Internal method to actually send the email using MailKit.
        /// This method is called by the background queue processor.
        /// </summary>
        /// <param name="emailMsg">The EmailMessage object containing all email details.</param>
        /// <param name="cancellationToken">Cancellation token to allow graceful shutdown.</param>
        private static async Task ProcessAndSendEmail(EmailMessage emailMsg, CancellationToken cancellationToken)
        {
            try
            {
                var message = new MimeMessage();
                message.From.Add(new MailboxAddress("eShift Logistics", emailAddress));
                message.To.Add(new MailboxAddress("", emailMsg.ToEmail));
                message.Subject = emailMsg.Subject;

                var bodyBuilder = new BodyBuilder();
                if (emailMsg.IsHtml)
                {
                    bodyBuilder.HtmlBody = emailMsg.Body;
                }
                else
                {
                    bodyBuilder.TextBody = emailMsg.Body;
                }

                if (!string.IsNullOrEmpty(emailMsg.AttachmentPath))
                {
                    if (File.Exists(emailMsg.AttachmentPath))
                    {
                        bodyBuilder.Attachments.Add(emailMsg.AttachmentPath);
                    }
                    else
                    {
                        Console.WriteLine($"Warning: Attachment file not found at '{emailMsg.AttachmentPath}'. Email sent without it.");
                    }
                }

                message.Body = bodyBuilder.ToMessageBody();

                using (var client = new SmtpClient())
                {
                    // Use async methods for non-blocking I/O
                    await client.ConnectAsync(smtpHost, smtpPort, SecureSocketOptions.StartTls, cancellationToken);
                    await client.AuthenticateAsync(emailAddress, emailPassword, cancellationToken);
                    await client.SendAsync(message, cancellationToken);
                    await client.DisconnectAsync(true, cancellationToken);
                }
                Console.WriteLine($"Email sent successfully to {emailMsg.ToEmail} for subject: {emailMsg.Subject}");
            }
            catch (OperationCanceledException)
            {
                Console.WriteLine($"Email sending to {emailMsg.ToEmail} for subject '{emailMsg.Subject}' was cancelled.");
                // Optionally re-enqueue if you want to retry cancelled emails later
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error sending email to {emailMsg.ToEmail} with subject '{emailMsg.Subject}': {ex.Message}");
                // IMPORTANT: Do NOT show MessageBox directly from a background thread.
                // Log the error or update UI status in a thread-safe way (using Invoke).
                // For a WinForms app, it's often better to log this error and allow the app to continue.
                // If critical, you might queue a message to be displayed on the UI thread.
            }
        }

        // --- Public Method to Enqueue Emails (using the original SendEmail name) ---

        /// <summary>
        /// Enqueues an email to be sent by the background processor.
        /// This method is non-blocking and replaces the direct sending.
        /// </summary>
        /// <param name="toEmail">The recipient's email address.</param>
        /// <param name="subject">The subject of the email.</param>
        /// <param name="body">The body of the email.</param>
        /// <param name="attachmentPath">Optional path to an attachment file.</param>
        /// <param name="isHtml">True if the body is HTML, false for plain text.</param>
        public static void SendEmail(string toEmail, string subject, string body, string attachmentPath = null, bool isHtml = false)
        {
            var emailMessage = new EmailMessage
            {
                ToEmail = toEmail,
                Subject = subject,
                Body = body,
                AttachmentPath = attachmentPath,
                IsHtml = isHtml
            };
            _emailQueue.Enqueue(emailMessage);
            Console.WriteLine($"Email enqueued for {toEmail} with subject: {subject}");
        }

        // The SendEmailWithAttachment method is now redundant since SendEmail handles attachments.
        // You can remove it or keep it as a convenience wrapper if desired,
        // but it will just call the main SendEmail (enqueue) method.
        /// <summary>
        /// Enqueues an email with an attachment (calls the main SendEmail method).
        /// This method is primarily for backward compatibility if you have existing calls.
        /// </summary>
        /// <param name="toEmail">The recipient's email address.</param>
        /// <param name="subject">The subject of the email.</param>
        /// <param name="body">The body of the email.</param>
        /// <param name="attachmentPath">Path to the attachment file.</param>
        public static void SendEmailWithAttachment(string toEmail, string subject, string body, string attachmentPath)
        {
            // Calls the new SendEmail method which enqueues the email
            SendEmail(toEmail, subject, body, attachmentPath: attachmentPath, isHtml: false);
        }
    }
}