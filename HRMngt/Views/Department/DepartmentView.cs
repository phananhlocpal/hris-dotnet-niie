using ComponentFactory.Krypton.Toolkit;
using HRMngt.Model;
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

        ComboBox IDepartmentView.cbDepartment => cbDepartment;

        ComboBox IDepartmentView.cbStatus => cbStatus;

        DataGridView IDepartmentView.dgvDepartmentList => dgvDepartmentList;

        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler EditEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;
        public event EventHandler SearchByUserId;
        public event EventHandler LoadDepartmentDialogToAddEvent;
        public event EventHandler LoadDepartmentDialogToEditEvent;
        public event EventHandler AddNewDepartmentDialog;
        public event EventHandler ReadEvent;

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
                    dgvDepartmentList.Rows[rowIndex].Cells[3].Value = dep.Manager;
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
            string connectionString = "Data Source=localhost;Initial Catalog=HR;Integrated Security=True;Encrypt=False";
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Select name from department ";
                List<string> items = new List<string>();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        items.Add(reader[0].ToString());
                    }
                }
                cbDepartment.DataSource = items;
                cbDepartment.DisplayMember = "Name";
                cbDepartment.Refresh();
                connection.Close();
            }
        }
        private void cbAddress_Changed()
        {
            string connectionString = "Data Source=localhost;Initial Catalog=HR;Integrated Security=True;Encrypt=False";
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Select location from department ";
                List<string> items = new List<string>();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        items.Add(reader[0].ToString());
                    }
                }
                cbStatus.DataSource = items;
                cbStatus.DisplayMember = "Name";
                cbStatus.Refresh();
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
            if (saveExcel.ShowDialog() == DialogResult.OK)
            {
                ToExcel(dgvDepartmentList, saveExcel.FileName);
            }
        }
    }
}
