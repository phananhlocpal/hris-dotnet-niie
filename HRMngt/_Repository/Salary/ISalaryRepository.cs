using HRMngt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMngt._Repository.Salary
{
    public interface ISalaryRepository
    {
        void Add(SalaryModel salary);
        void Update(SalaryModel salary);
        void Delete(string userId, int month, int year);
        IEnumerable<SalaryModel> GetAll();
        SalaryModel LINQ_GetModelByPK(IEnumerable<SalaryModel> salaryList, string userId, int month, int year);
    }
}
