using ComponentFactory.Krypton.Toolkit;
using HRMngt.Model;
using HRMngt.Models;
using HRMngt.View;
using HRMngt.Views.Dialogs;
using HRMngt.Views.Salary;
using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class SalaryView : Form, ISalaryView
    {
        public SalaryView()
        {
            InitializeComponent();
        }

        private void RunEvent()
        {
            /*btnAdd.Click += delegate { LoadSalaryDialogToAddEvent?.Invoke(this, EventArgs.Empty); };*/
            dgvSalaryList.CellContentClick += (sender, e) =>
            {
                if (e.RowIndex >= 0 && e.ColumnIndex == dgvSalaryList.Columns[5].Index)
                {
                    CheckSalary?.Invoke(this, EventArgs.Empty);
                }
            };
        }
        public event EventHandler CheckSalary;
        public event EventHandler LoadSalaryToEdit;
        public event EventHandler LoadSalaryToDelete;

        ComboBox ISalaryView.cbDepartment => cbDepartment;

        ComboBox ISalaryView.cbStatus => cbStatus;

        DataGridView ISalaryView.dgvSalaryList => dgvSalaryList;
        private static SalaryView instance;
        public static SalaryView GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new SalaryView();
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
                worksheet.Name = "Quản lý lương";
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
                ToExcel(dgvSalaryList, saveExcel.FileName);
            }
        }

        public DepartmentDiaglog ShowSalaryDialogToAdd()
        {
            throw new NotImplementedException();
        }

        public DepartmentDiaglog ShowSalaryDialogToEdit(string id)
        {
            throw new NotImplementedException();
        }

        public void ShowSalaryList(IEnumerable<SalaryListModel> salaryList)
        {
            if (salaryList != null)
            {
                dgvSalaryList.Rows.Clear();

                foreach (var salary in salaryList)
                {
                    int rowIndex = dgvSalaryList.Rows.Add();
                    dgvSalaryList.Rows[rowIndex].Cells[0].Value = salary.UserId;
                    dgvSalaryList.Rows[rowIndex].Cells[1].Value = salary.Name;
                    
                    dgvSalaryList.Rows[rowIndex].Cells[2].Value = salary.ContractType;
                    dgvSalaryList.Rows[rowIndex].Cells[3].Value = salary.Position;
                    dgvSalaryList.Rows[rowIndex].Cells[4].Value = "• "+salary.SalaryStatus;
                    if (salary.SalaryStatus == "Đã xác nhận")
                    {
                        dgvSalaryList.Rows[rowIndex].Cells[4].Style.ForeColor = Color.FromArgb(69, 158, 26);
                    }
                    else
                    {
                        dgvSalaryList.Rows[rowIndex].Cells[4].Style.ForeColor = Color.Red;
                    }
                }
            }
            else dgvSalaryList.Rows.Clear();
        }
    }
}
