using HRMngt.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMngt._Repository
{
    public interface ILoginRepository
    {
        string Login(string username, string password);
        UserModel GetById(string id);
    }
}
