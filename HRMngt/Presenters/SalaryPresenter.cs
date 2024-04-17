using HRMngt._Repository.Salary;
using HRMngt.Models;
using HRMngt.Views.Salary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMngt.Presenters
{
    public class SalaryPresenter
    {
        private ISalaryView view;
        private ISalaryRepository repository;
        private IEnumerable<SalaryModel> salaryList;
        private IEnumerable<SalaryListModel> salaryGetList;

        public SalaryPresenter(ISalaryView view, ISalaryRepository repository)
        {
            this.view = view;
            this.repository = repository;
            this.view.CheckSalary += CheckSalary;
            LoadAllSalaryList();
            this.view.ShowSalaryList(salaryGetList);
            this.view.Show();
        }

        private void CheckSalary(object sender, EventArgs e)
        {
            
        }

        private void LoadAllSalaryList()
        {
            salaryGetList = repository.GetList();
        }
    }
}
