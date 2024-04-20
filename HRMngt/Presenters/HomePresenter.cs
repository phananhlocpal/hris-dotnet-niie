using HRMngt._Repository;
using HRMngt.Models;
using HRMngt.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMngt.Presenters
{
    public class HomePresenter
    {
        private IHomeView view;
        private IUserRepository repository;

        public HomePresenter(IHomeView view, IUserRepository repository)
        {
            this.view = view;
            this.repository = repository;

            this.view.Show();
        }
    }
}
