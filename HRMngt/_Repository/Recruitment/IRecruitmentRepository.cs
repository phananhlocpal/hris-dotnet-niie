using HRMngt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMngt._Repository.Recruitment
{
    public interface IRecruitmentRepository
    {
        void Add(UserModel userModel);
        void Edit(UserModel userModel);
        void Delete(string id);

        IEnumerable<UserModel> GetAll();
        void SendMail(string password, string email, string username, string name);

        //LINQ
        UserModel LINQ_GetModelById(IEnumerable<UserModel> userList, string id);
        IEnumerable<UserModel> Filter(IEnumerable<UserModel> recruitmentList, string department, string status);

        string LINQ_GetUsername(IEnumerable<UserModel> userList, string id);
        string LINQ_GetPassword(IEnumerable<UserModel> userList, string id);
    }
}
