using eShift_Logistics_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShift_Logistics_System.Business.Interface
{
    internal interface IUserService
    {
       
        void AddUser(User user);
       
        void UpdateUser(User user);
        
        bool DeleteUser(string customerNumber);
       
        List<User> GetAllUsers();
      
        bool ToggleUserStatus(string customerNumber);

        User AuthenticateUser(string email, string password);
       
        int GetActiveCustomerCount();
        User GetUserById(int id);

        void UpdateUserProfile(User user);
      
        bool ChangePassword(int userId, string currentPassword, string newPassword);
    }
}
