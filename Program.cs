using eShift_Logistics_System.Forms;
using eShift_Logistics_System.Forms.Admin;
using eShift_Logistics_System.Forms.Customer;
using QuestPDF.Infrastructure;
using System.Globalization;
using QuestPDF.Infrastructure;
using eShift_Logistics_System.Helpers;

namespace eShift_Logistics_System
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            QuestPDF.Settings.License = LicenseType.Community;

            CultureInfo sriLankanCulture = new CultureInfo("si-LK");
            Thread.CurrentThread.CurrentCulture = sriLankanCulture;
            Thread.CurrentThread.CurrentUICulture = sriLankanCulture;
            EmailHelper.StartEmailQueueProcessor();

            Application.Run(new LoginForm());
            EmailHelper.StopEmailQueueProcessor();

        }
    }
}