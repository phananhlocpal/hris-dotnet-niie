using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace HRMngt.Views
{
    public interface IHomeView
    {
        Button btnCheckin { get; }
        Button btnCheckout { get; }

        void Show();

    }
}
