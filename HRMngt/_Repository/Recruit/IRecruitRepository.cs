using HRMngt.Model;
using HRMngt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRMngt._Repository.HR
{
    public interface IRecruitRepository
    {
        void Add(RecruitModel recruitModel);
        void Edit(RecruitModel recruitModel);
        void Delete(string id);

        IEnumerable<RecruitModel> GetAll();
        RecruitModel GetById(string id);

        string UpdateStatus(string type, string id);
        string UpdateStatusAll(string type);

        string GetStatus(string id);

        void UpdateRecruitToUser(RecruitModel recruitModel);
        string GetDepartmentID(string departmentName);

    }
}
