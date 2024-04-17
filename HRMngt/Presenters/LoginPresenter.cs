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
            string name = view.username;
            string pass = view.password;
            ID_USER = repository.Login(name, pass);
            if (ID_USER != "")
            {
                UserModel user = repository.GetById(ID_USER);
                IMainView main = new MainView();
                this.view.Hide();
                presenter = new MainViewPresenter(main, user);
                MessageBox.Show("Đăng nhập thành công", "Thành công", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Tài khoản và mật khẩu không đúng !");
            }
        }

    }
}
