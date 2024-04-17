using HRMngt._Repository.Support;
using HRMngt.Views.Dialogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMngt.Presenters
{
    public class SupportPresenter
    {
        private ISupport view;
        private ISupportRepository repository;

        public SupportPresenter(ISupport view, ISupportRepository repository)
        {
            this.view = view;
            this.repository = repository;
            this.view.Send += Send;

            this.view.Show();
        }

        private void Send(object sender, EventArgs e)
        {
            
        }
    }
}
