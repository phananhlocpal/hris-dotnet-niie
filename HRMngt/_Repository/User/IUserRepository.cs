using HRMngt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace HRMngt._Repository
{
    public interface IUserRepository
    {
        void Add(UserModel userModel);
        void Update(UserModel userModel);
        void Delete(string id);
        IEnumerable<UserModel> GetAll();
        
        IEnumerable<UserModel> GetByValue(); // Search
        List<string> GetUserIdNName();
        List<string> GetDepartmentIDName();// Get "ID - Name"
        string GetNameById(string id);
        
        UserModel GetById(string id);
        UserModel Authenticator(string username, string password);
        string RandomPasswords();
        string GetNameDepartmentById(string id);

        void SendMail(string password, string userID);
<<<<<<< HEAD
        UserModel LINQ_getManagerById(IEnumerable<UserModel> userList, string id);


=======


        //LINQ
        UserModel LINQ_GetModelById(IEnumerable<UserModel> userList, string id);
        IEnumerable<UserModel> Filter(IEnumerable<UserModel> userList, string department, string status);
        IEnumerable<UserModel> LINQ_GetAllManager(IEnumerable<UserModel> userList, string managerID);
        IEnumerable<UserModel> LINQ_GetAllUser(IEnumerable<UserModel> userList, string departmentID);
>>>>>>> hieu-new
    }
}
