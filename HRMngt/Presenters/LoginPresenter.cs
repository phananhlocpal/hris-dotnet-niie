using ComponentFactory.Krypton.Toolkit;
using HRMngt._Repository;
using HRMngt.Model;
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
        private string connectionString = @"Data Source=localhost;Initial Catalog=HR;Integrated Security=True;";
        private ILoginView view;
        private ILoginRepository repository;
        public static string ID_USER = "";
        private MainViewPresenter presenter;
        public LoginPresenter(ILoginView view, ILoginRepository repository)
        {
            this.view = view;
            this.repository = repository;
            
            this.view.LoginEvent += LoginEvent;
            this.view.Show();
        }

        private void LoginEvent(object sender, EventArgs e)
        {
            int count = Views.LoginView.count;
            string name = view.username;
            string pass = view.password;
            ID_USER = repository.Login(name, pass);
            if (ID_USER != "")
            {
                UserModel user = repository.GetById(ID_USER);
                IMainView main = new MainView(user);
                this.view.Hide();
                
                presenter = new MainViewPresenter(main, user);
                MessageBox.Show("Đăng nhập thành công", "Thành công", MessageBoxButtons.OK);
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
                    Views.LoginView.count = 0;
                }
                else
                {
                    MessageBox.Show("Tên người dùng hoặc mật khẩu không đúng. Vui lòng thử lại.", "Đăng nhập thất bại", MessageBoxButtons.OK);
                }
            }
            
        }

    }
}
