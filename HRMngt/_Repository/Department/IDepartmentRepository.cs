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

        //LINQ
        IEnumerable<DepartmentModel> LINQ_Filter(IEnumerable<DepartmentModel> departmentList, string manager);
        DepartmentModel LINQ_GetModelById(IEnumerable<DepartmentModel> departmentList, string id);


    }
}
