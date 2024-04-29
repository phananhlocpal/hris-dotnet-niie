using ComponentFactory.Krypton.Toolkit;
using HRMngt._Repository;
using HRMngt.Models;
using HRMngt.View;
using HRMngt.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace HRMngt.Presenters
{
    public class LoginPresenter
    {
        private ILoginView view;
        private IUserRepository repository;
        private int count = 0;

        public LoginPresenter(ILoginView view, IUserRepository repository)
        {
            // Constructor
            this.view = view;
            this.repository = repository;
            
            // Event Handler
            this.view.LoginEvent += LoginEvent;
            this.view.Show();
        }

        private void LoginEvent(object sender, EventArgs e)
        {
            string username = view.username;
            string password = view.password;
            UserModel userModel = new UserModel();
            userModel = repository.Authenticator(username, password);
            // Check authenticator
            if (userModel != null && !string.IsNullOrEmpty(userModel.Username))
            {
                IMainView main = new MainView();
                new MainViewPresenter(main, userModel);
                this.view.Hide();

            }
            else
            {
                if (count == 3)
                {
                    MessageBox.Show("Đã nhập sai quá nhiều lần. Vui lòng thử lại sau.", "Đăng nhập thất bại", MessageBoxButtons.OK);
                    view.EnableLogin(false);
                    ClockCountdown clock = new ClockCountdown();
                    clock.ShowDialog();
                    view.EnableLogin(true);
                    count = 0;
                }
                else
                {
                    MessageBox.Show("Sai mật khẩu hoặc tên đăng nhập");
                    count++;
                }
            }
            
        }

    }
}
