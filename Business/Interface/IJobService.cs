using eShift_Logistics_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShift_Logistics_System.Business.Interface
{
    public interface IJobService
    {
        
        void CreateNewJob(Job job);

        List<Job> GetAllJobsWithDetails();

        void AssignUnitAndFinalizeJob(Job job);
       
        decimal CalculateEstimatedCost(List<Load> loads);
       
        Job GetJobWithDetailsById(int jobId);
       
        void UpdateJobStatus(int jobId, JobStatus newStatus);
       
        List<Job> GetJobsByCustomerId(int customerId);
      
        int GetJobCountByStatus(JobStatus? status = null);
      
        List<Job> GetRecentJobs(int limit = 5);
        
        List<Job> GetLatestAssignedJobs(int limit = 5);
        
        int GetJobCountByCustomer(int customerId, JobStatus? status = null);

        List<Job> GetRecentJobsByCustomer(int customerId, int limit = 5);
       
        bool CancelJob(int jobId);

    }
}
