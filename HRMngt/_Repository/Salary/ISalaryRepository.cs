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
        void Edit(SalaryModel salary);
        void Delete(string id);
        IEnumerable<SalaryModel> GetAll();
        IEnumerable<SalaryListModel> GetList();

        SalaryModel GetByID(string id);
    }
}
