using HRMngt.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRMngt.Views.Dialogs
{
    public partial class HRDialog : Form, IHRDialog
    {
        private string type;
        public HRDialog()
        {
            InitializeComponent();
            RunEvent();
            
        }
        private void RunEvent()
        {
            btnAdd.Click += delegate
            {
                LoadAddDialogHR?.Invoke(this, EventArgs.Empty);
            };
        }
        public string NameCadidate { get => txtName.Text; set => txtName.Text = value; }
        public string Email { get => txtEmail.Text; set => txtEmail.Text = value; }
        public string Address { get => txtAddress.Text; set => txtAddress.Text = value; }
        public string Phone { get => txtPhone.Text; set => txtPhone.Text = value; }
        public string Position { get => cbPosition.Text; set => cbPosition.Text = value; }
        public string Roles { get => cbRoles.Text; set => cbRoles.Text = value; }
        public string Note { get => txtNote.Text; set => txtNote.Text = value; }
        public DateTime Birthday { get => dateTime.Value; set => dateTime.Value=value; }
        public string Sex { get => cbSex.Text; set => cbSex.Text = value; }
        public string Status { get => cbStatus.Text; set => cbStatus.Text = value; }
        public string Contract_type { get => cbContractType.Text; set => cbContractType.Text = value; }

        public event EventHandler LoadAddDialogHR;
        public event EventHandler LoadEditDialogHR;

        public void ShowRecruitList(IEnumerable<UserModel> recruits)
        {
            throw new NotImplementedException();
        }
    }
}
