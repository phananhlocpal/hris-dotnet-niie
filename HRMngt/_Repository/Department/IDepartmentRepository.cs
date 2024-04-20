using HRMngt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMngt._Repository
{
    public interface IDepartmentRepository
    {
        void Add(DepartmentModel department);
        void Edit(DepartmentModel department);
        void Delete(string id);
        IEnumerable<DepartmentModel> GetAll();
        IEnumerable<DepartmentModel> GetByDepartmentName(string name);
        
        IEnumerable<DepartmentModel> GetByAddress(string address);
        DepartmentModel GetById(string id);
    }
}
