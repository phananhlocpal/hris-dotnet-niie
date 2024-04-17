using HRMngt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMngt._Repository.IndividualSalary
{
    public interface IIndividualSalaryRepository
    {
        void Update(SalaryModel salaryModel);
        IEnumerable<SalaryModel> GetAllByUserID(string id);
        SalaryModel GetByKey(string userId, int month, int year);
    }
}
