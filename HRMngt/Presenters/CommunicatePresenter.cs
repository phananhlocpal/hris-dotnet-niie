using HRMngt._Repository.Communicate;
using HRMngt.Views;
using HRMngt.Views.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMngt.Presenters
{
    public class CommunicatePresenter
    {
        private IClientView view;
        private ICommunicateRepository repository;

        public CommunicatePresenter(IClientView view, ICommunicateRepository repository)
        {
            this.view = view;
            this.repository = repository;

            this.view.Show();
        }
    }
}
