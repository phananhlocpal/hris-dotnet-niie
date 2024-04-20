using HRMngt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace HRMngt.Model
{
    public interface IUserRepository
    {
        void Add(UserModel userModel);
        void Update(UserModel userModel);
        void Delete(string id);
        string RandomPasswords();
        IEnumerable<UserModel> GetAll();
        UserModel Authenticator(string username, string password);

        // LINQ
        UserModel LINQ_GetModelById(IEnumerable<UserModel> userList, string id);
        IEnumerable<UserModel> LINQ_GetManagerList(IEnumerable<UserModel> userList);

        void SendMail(string password, string userID);
        
    }
}
