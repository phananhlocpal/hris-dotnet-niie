using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMngt.Views
{
    public interface ILoginView
    {
        
        string username { get; set; }
        string password { get; set; }  
        event EventHandler LoginEvent;

        void EnableLogin(bool type = true);
        void Show();
        void Hide();
    }
}
