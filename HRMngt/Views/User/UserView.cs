using Bunifu.UI.WinForms.BunifuButton;
using HRMngt.Models;
using HRMngt.View;
using HRMngt.Views.Dialogs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
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
            GetNameDepartmentFilter();
            cbStatus.SelectedIndex = 0;
        }

        public void RunEvent()
        {
            btnAdd.Click += delegate { LoadUserDialogToAddEvent?.Invoke(this, EventArgs.Empty); };
            dgvUserList.CellContentClick += (sender, e) =>
            {
                if (e.RowIndex >= 0 && e.ColumnIndex == dgvUserList.Columns[9].Index)
                {
                    LoadUserDialogToEditEvent?.Invoke(this, EventArgs.Empty);
                }
            };
            dgvUserList.CellContentClick += (sender, e) =>
            {
                if (e.RowIndex >= 0 && e.ColumnIndex == dgvUserList.Columns[10].Index)
                {
                    DeleteEvent?.Invoke(this, EventArgs.Empty);
                }
            };
            cbDepartment.SelectedValueChanged += delegate { FilterUser?.Invoke(this, EventArgs.Empty); };
            cbStatus.SelectedValueChanged += delegate { FilterUser?.Invoke(this, EventArgs.Empty); };


        }
        private static UserView instance;
        ComboBox IUserView.cbDepartment => cbDepartment;

        ComboBox IUserView.cbStatus => cbStatus;

        DataGridView IUserView.dgvUserList => dgvUserList;

        public BunifuButton2 ButtonAdd => btnAdd;

        public DataGridViewImageColumn ButtonEdit => btnEdit;

        public DataGridViewImageColumn ButtonDelete => btnDelete;

        public DataGridViewImageColumn ButtonRead => btnRead;

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
        public event EventHandler FilterUser;

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
        private void GetNameDepartmentFilter()
        {
            string connectionString = "Data Source=localhost;Initial Catalog=hris;Integrated Security=True;Encrypt=False";
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Select distinct departmentID, name from department ";
                List<string> items = new List<string>();
                using (var reader = command.ExecuteReader())
                {
                    items.Add("All");
                    while (reader.Read())
                    {

                        items.Add($"{reader[0]} - {reader[1]}");
                    }
                }
                cbDepartment.DataSource = items;
                cbDepartment.DisplayMember = "Name";
                cbDepartment.Refresh();
                connection.Close();
            }
        }
        
        private string GetNameDepartment(string id)
        {
            string name = "";
            string connectionString = "Data Source=localhost;Initial Catalog=hris;Integrated Security=True;Encrypt=False";
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Select distinct name from department where departmentID = @Id";
                command.Parameters.Add("@Id", SqlDbType.Char).Value = id;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        name = reader[0].ToString();
                    }
                }

            }
            return name;
        }


        public void ShowUserList(IEnumerable<UserModel> userList, UserModel userModel)
        {
            if (userList != null)
            {
                dgvUserList.Rows.Clear();

                foreach (var user in userList)
                {
                    
                    if (user.Status == "On-boarding" && user.Id != userModel.Id)
                    {
                        int rowIndex = dgvUserList.Rows.Add();

                        // Thêm hình ảnh từ mảng byte vào cột hình ảnh
                        if (user.Photo != null && user.Photo.Length > 0)
                        {
                            // Chuyển đổi mảng byte thành hình ảnh
                            Image image = ImageFromByteArray(user.Photo);
                            // Gán hình ảnh vào cột hình ảnh đầu tiên
                            dgvUserList.Rows[rowIndex].Cells[0].Value = image;
                        }
                        // Tiếp tục gán các giá trị khác vào các cột khác
                        dgvUserList.Rows[rowIndex].Cells[1].Value = user.Id;
                        dgvUserList.Rows[rowIndex].Cells[2].Value = user.Name;
                        dgvUserList.Rows[rowIndex].Cells[3].Value = GetNameDepartment(user.DepartmentID);
                        dgvUserList.Rows[rowIndex].Cells[4].Value = user.Contract_type;
                        dgvUserList.Rows[rowIndex].Cells[5].Value = user.Position;
                        dgvUserList.Rows[rowIndex].Cells[6].Value = "• " + user.Status;
                        dgvUserList.Rows[rowIndex].Cells[7].Value = user.Roles;

                        dgvUserList.Rows[rowIndex].Cells[6].Style.ForeColor = Color.FromArgb(255, 212, 59);
                        
                    }
                }
            }
            else
            {
                dgvUserList.Rows.Clear();
            }
        }
        private Image ImageFromByteArray(byte[] byteArray)
        {
            using (MemoryStream memoryStream = new MemoryStream(byteArray))
            {
                Image image = Image.FromStream(memoryStream);
                return image;
            }
        }

        public UserDialog ShowUserDialogToAdd()
        {
            UserDialog dialog = new UserDialog("Thêm");
            return dialog;
        }

        public UserDialog ShowUserDialogToEdit(string id)
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
