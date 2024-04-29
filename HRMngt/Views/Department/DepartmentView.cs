using Bunifu.UI.WinForms.BunifuButton;
using ComponentFactory.Krypton.Toolkit;
using HRMngt.Models;
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

namespace HRMngt.Views
{
    public partial class DepartmentView : Form, IDepartmentView
    {
        public DepartmentView()
        {
            InitializeComponent();
            cbDepartment_SelectedIndexChanged();
            cbAddress_Changed();
            RunEvent();
        }

        ComboBox IDepartmentView.cbManager => cbManager;

        ComboBox IDepartmentView.cbAddress => cbAddress;

        DataGridView IDepartmentView.dgvDepartmentList => dgvDepartmentList;

        public BunifuButton2 buttonAdd => btnAdd;

        public DataGridViewImageColumn buttonEdit => btnEdit;

        public DataGridViewImageColumn buttonDelete => btnDelete;

        public DataGridViewImageColumn buttonRead => btnRead;

        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler EditEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;
        public event EventHandler LoadDepartmentDialogToAddEvent;
        public event EventHandler LoadDepartmentDialogToEditEvent;
        public event EventHandler AddNewDepartmentDialog;
        public event EventHandler ReadEvent;
        public event EventHandler SearchByDepartmentName;
        public event EventHandler SearchByDepartmentAddress;
        public event EventHandler FiterDepartment;

        private void RunEvent()
        {
            btnAdd.Click += delegate { LoadDepartmentDialogToAddEvent?.Invoke(this, EventArgs.Empty); };

            dgvDepartmentList.CellContentClick += (sender, e) =>
            {
                if (e.RowIndex >= 0 && e.ColumnIndex == dgvDepartmentList.Columns[6].Index)
                {
                    LoadDepartmentDialogToEditEvent?.Invoke(this, EventArgs.Empty);
                }
            };
            dgvDepartmentList.CellContentClick += (sender, e) =>
            {
                if (e.RowIndex >= 0 && e.ColumnIndex == dgvDepartmentList.Columns[7].Index)
                {
                    DeleteEvent?.Invoke(this, EventArgs.Empty);
                }
            };

            dgvDepartmentList.CellContentClick += (sender, e) =>
            {
                if (e.RowIndex >= 0 && e.ColumnIndex == dgvDepartmentList.Columns[5].Index)
                {
                    ReadEvent?.Invoke(this, EventArgs.Empty);
                }
            };
            cbManager.SelectedValueChanged += delegate { FiterDepartment?.Invoke(this, EventArgs.Empty); };
            cbAddress.SelectedValueChanged += delegate { FiterDepartment?.Invoke(this, EventArgs.Empty); };

        }
        public string GetNameByIDUser(string id)
        {
            string name = "";
            string connectionString = "Data Source=localhost;Initial Catalog=hris;Integrated Security=True;Encrypt=False";
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Select distinct name from users where userID = @Id";
                command.Parameters.Add("@Id", SqlDbType.NVarChar).Value = id;
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
        public void ShowDepartmentList(IEnumerable<DepartmentModel> departments)
        {

            if (departments != null)
            {
                dgvDepartmentList.Rows.Clear();

                foreach (var dep in departments)
                {
                    int rowIndex = dgvDepartmentList.Rows.Add();
                    dgvDepartmentList.Rows[rowIndex].Cells[0].Value = dep.Id;
                    dgvDepartmentList.Rows[rowIndex].Cells[1].Value = dep.Name;
                    dgvDepartmentList.Rows[rowIndex].Cells[2].Value = dep.Phone;
                    dgvDepartmentList.Rows[rowIndex].Cells[3].Value = GetNameByIDUser(dep.Manager);
                    dgvDepartmentList.Rows[rowIndex].Cells[4].Value = dep.Location;
                }
            }
            else dgvDepartmentList.Rows.Clear();
        }
        private static DepartmentView instance;
        public static DepartmentView GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new DepartmentView();
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
        private void cbDepartment_SelectedIndexChanged()
        {
            string connectionString = "Data Source=localhost;Initial Catalog=hris;Integrated Security=True;Encrypt=False;";
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Select distinct userID, name from users where role = @Roles ";
                command.Parameters.Add("@Roles", SqlDbType.NVarChar).Value = "Admin";
                List<string> items = new List<string>();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        items.Add($"{reader[0]} - {reader[1]}");
                    }
                }
                cbManager.DataSource = items;
                cbManager.DisplayMember = "Name";
                cbManager.Refresh();
                connection.Close();
            }
        }
        private void cbAddress_Changed()
        {
            string connectionString = "Data Source=localhost;Initial Catalog=hris;Integrated Security=True;Encrypt=False";
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Select distinct location from department ";
                List<string> items = new List<string>();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        items.Add(reader[0].ToString());
                    }
                }
                cbAddress.DataSource = items;
                cbAddress.DisplayMember = "Name";
                cbAddress.Refresh();
                connection.Close();
            }
        }



        public DepartmentDiaglog ShowDepartmentDialogToAdd()
        {
            DepartmentDiaglog diaglog = new DepartmentDiaglog("Thêm");
            return diaglog;
        }
        public DepartmentDiaglog ShowDepartmentDialogToEdit(string id)
        {
            DepartmentDiaglog diaglog = new DepartmentDiaglog("Sửa");
            return diaglog;
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
                worksheet.Name = "Quản lý phòng ban";
                // Xuất tiêu đề cột
                for (int i = 0; i < dataGridView1.ColumnCount; i++)
                {
                    worksheet.Cells[1, i + 1] = dataGridView1.Columns[i].HeaderText;
                }
                // Xuất dữ liệu từ DataGridView
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    for (int j = 0; j < 5; j++) // Chỉ xuất 5 cột đầu
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
            if (saveExcel.ShowDialog() == DialogResult.OK)
            {
                ToExcel(dgvDepartmentList, saveExcel.FileName);
            }
        }

        
    }
}
