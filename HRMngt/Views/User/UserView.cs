using HRMngt.Model;
using HRMngt.View;
using HRMngt.Views.Dialogs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRMngt.Views.User
{
    public partial class UserView : Form, IUserView
    {
        public UserView()
        {
            InitializeComponent();
            RunEvent();
        }

        public void RunEvent()
        {
            btnAdd.Click += delegate { LoadUserDialogToAddEvent?.Invoke(this, EventArgs.Empty); };
            dgvUserList.CellContentClick += (sender, e) =>
            {
                if (e.RowIndex >= 0 && e.ColumnIndex == dgvUserList.Columns[8].Index)
                {
                    LoadUserDialogToEditEvent?.Invoke(this, EventArgs.Empty);
                }
            };
            dgvUserList.CellContentClick += (sender, e) =>
            {
                if (e.RowIndex >= 0 && e.ColumnIndex == dgvUserList.Columns[9].Index)
                {
                    DeleteEvent?.Invoke(this, EventArgs.Empty);
                }
            };
            
           
        }
        private static UserView instance;
        ComboBox IUserView.cbDepartment => cbDepartment;

        ComboBox IUserView.cbStatus => cbStatus;

        DataGridView IUserView.dgvUserList => dgvUserList;

        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler EditEvent;
        public event EventHandler ReadEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;
        public event EventHandler SearchByUserId;
        public event EventHandler LoadUserDialogToEditEvent;
        public event EventHandler LoadUserDialogToAddEvent;
        public event EventHandler AddNewDepartmentDialog;
        public event EventHandler GeneratedEventLoadEmail;
        public event EventHandler DeleteAll;

        public static UserView GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new UserView();
                instance.MdiParent = parentContainer;
                instance.FormBorderStyle = FormBorderStyle.None;
                instance.Dock = DockStyle.Fill;
            }
            else
            {
                if (instance.WindowState == FormWindowState.Minimized)
                    instance.WindowState = FormWindowState.Normal;
                instance.BringToFront();
            }
            return instance;
        }
       

        public void ShowUserList(IEnumerable<UserModel> userList)
        {
            if (userList != null)
            {
                dgvUserList.Rows.Clear();

                foreach (var user in userList)
                {
                    int rowIndex = dgvUserList.Rows.Add();
                    dgvUserList.Rows[rowIndex].Cells[0].Value = user.Id;
                    dgvUserList.Rows[rowIndex].Cells[1].Value = user.Name;
                    dgvUserList.Rows[rowIndex].Cells[2].Value = user.DepartmentID;
                    dgvUserList.Rows[rowIndex].Cells[3].Value = user.Contract_type;
                    dgvUserList.Rows[rowIndex].Cells[4].Value = user.Position;
                    dgvUserList.Rows[rowIndex].Cells[5].Value = "• " + user.Status;
                    dgvUserList.Rows[rowIndex].Cells[6].Value = user.Roles;
                    if (user.Status == "Đang làm")
                    {
                        dgvUserList.Rows[rowIndex].Cells[5].Style.ForeColor = Color.FromArgb(69, 158, 26);
                    }
                    else
                    {
                        dgvUserList.Rows[rowIndex].Cells[5].Style.ForeColor = Color.FromArgb(255, 212, 59);
                    }
                }
            }
            else dgvUserList.Rows.Clear();
        }

        public UserDialog ShowUserDialogToAdd()
        {
            UserDialog dialog = new UserDialog("Thêm");
            return dialog;
        }

        public UserDialog ShowUserDialogToEdit()
        {
            UserDialog dialog = new UserDialog("Sửa");
            return dialog;
        }
        private void ToExcel(DataGridView dataGridView1, string fileName)
        {
            Microsoft.Office.Interop.Excel.Application excel;
            Microsoft.Office.Interop.Excel.Workbook workbook;
            Microsoft.Office.Interop.Excel.Worksheet worksheet;
            try
            {
                excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Visible = false;
                excel.DisplayAlerts = false;
                workbook = excel.Workbooks.Add(Type.Missing);
                worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets["Sheet1"];
                worksheet.Name = "Quản lý nhân viên";
                for (int i = 0; i < dataGridView1.ColumnCount; i++)
                {
                    worksheet.Cells[1, i + 1] = dataGridView1.Columns[i].HeaderText;
                }
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                    }
                }
                workbook.SaveAs(fileName);
                workbook.Close();
                excel.Quit();
                MessageBox.Show("Xuất dữ liệu ra Excel thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                workbook = null;
                worksheet = null;
            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ToExcel(dgvUserList, saveFileDialog1.FileName);
            }
        }

        private void UserView_Load(object sender, EventArgs e)
        {

        }
    }
}
