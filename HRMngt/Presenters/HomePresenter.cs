using HRMngt._Repository.Home;
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
        private IHomeRepository repository;

        public HomePresenter(IHomeView view, IHomeRepository repository)
        {
            this.view = view;
            this.repository = repository;

            this.view.Show();
        }
    }
}
