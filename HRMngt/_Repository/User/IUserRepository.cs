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
        // CRUD
        void Add(UserModel userModel);
        void Update(UserModel userModel);
        void Delete(string id);
        IEnumerable<UserModel> GetAll();
<<<<<<< HEAD

        // Others
=======
        
        List<string> GetDepartmentIDName();// Get "ID - Name"
        
        UserModel GetById(string id);
>>>>>>> new-mhieu
        UserModel Authenticator(string username, string password);
        string RandomPasswords();
        void SendMail(string password, string userID);

        //LINQ
        UserModel LINQ_getManagerById(IEnumerable<UserModel> userList, string id);
        UserModel LINQ_GetModelById(IEnumerable<UserModel> userList, string id);
        IEnumerable<UserModel> Filter(IEnumerable<UserModel> userList, string department, string status);
        IEnumerable<UserModel> LINQ_GetAllManager(IEnumerable<UserModel> userList, string managerID);
        IEnumerable<UserModel> LINQ_GetListManager(IEnumerable<UserModel> userList);
        IEnumerable<UserModel> LINQ_GetAllUser(IEnumerable<UserModel> userList, string departmentID);
        IEnumerable<UserModel> LINQ_GetListByManager(IEnumerable<UserModel> userList, string managerID);
    }
}
