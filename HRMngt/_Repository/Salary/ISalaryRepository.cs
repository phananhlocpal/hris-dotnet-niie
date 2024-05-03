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
        // CRUD with ADO
        void Add(SalaryModel salary);
        void Update(SalaryModel salary);
        void Delete(string userId, int month, int year);
        IEnumerable<SalaryModel> GetAll();

        // LINQ_Method
        SalaryModel LINQ_GetModelByPK(IEnumerable<SalaryModel> salaryList, string userId, int month, int year);
        bool LINQ_CheckExistIndividualSalary(IEnumerable<SalaryModel> salaryList, string userId, int month, int year);
        bool LINQ_CheckExistSalary(IEnumerable<SalaryModel> salaryList, int month, int year);
        IEnumerable<SalaryModel> LINQ_GetListByMonthNYear(IEnumerable<SalaryModel> salaryList, int month, int year);
        IEnumerable<SalaryModel> LINQ_Filter(IEnumerable<SalaryModel> salaryList, string departmentId, string status, int month, int year);
        IEnumerable<SalaryModel> LINQ_GetListByManagerNMonthNYear(IEnumerable<SalaryModel> salaryList, string managerId, int month, int year);
    }
}
