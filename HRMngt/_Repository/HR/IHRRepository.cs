using HRMngt.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMngt._Repository.HR
{
    public interface IHRRepository
    {
        void Add(UserModel userModel);
        void Edit(UserModel userModel);
        void Delete(string id);

        IEnumerable<UserModel> GetAll();

    }
}
