﻿using ComponentFactory.Krypton.Toolkit;
using HRMngt.Model;
using HRMngt.Models;
using HRMngt.Views.Dialogs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRMngt.Views.HR
{
    public partial class RecruitView : Form, IRecruitView
    {
        public RecruitView()
        {
            InitializeComponent();
            RunEvent();
        }

        public void RunEvent()
        {
            // Add event
            btnAdd.Click += delegate { LoadHRToAdd?.Invoke(this, EventArgs.Empty); };
            // Edit event
            dgvHRList.CellContentClick += (sender, e) =>
            {
                if (e.RowIndex >= 0 && e.ColumnIndex == dgvHRList.Columns[7].Index)
                {
                    LoadHRToEdit?.Invoke(this, EventArgs.Empty);
                }
            };
            // Delete event
            dgvHRList.CellContentClick += (sender, e) =>
            {
                if (e.RowIndex >= 0 && e.ColumnIndex == dgvHRList.Columns[8].Index)
                {
                    DeleteHR?.Invoke(this, EventArgs.Empty);
                }
            };
        }

        // Get method
        ComboBox IRecruitView.cbDepartment => cbDepartment;
        ComboBox IRecruitView.cbStatus => cbStatus;
        KryptonDataGridView IRecruitView.dgvHRList => dgvHRList;
        SaveFileDialog IRecruitView.saveFile => saveFile;

        // Event Handler
        public event EventHandler DeleteHR;
        public event EventHandler LoadHRToAdd;
        public event EventHandler LoadHRToEdit;

        // MDI Processing
        private static RecruitView instance;
        public static RecruitView GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new RecruitView();
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
       

        public void ShowHRList(IEnumerable<UserModel> userList)
        {
            if (userList != null)
            {
                dgvHRList.Rows.Clear();

                foreach (var recruit in userList)
                {
                    int rowIndex = dgvHRList.Rows.Add();
                    dgvHRList.Rows[rowIndex].Cells[0].Value = recruit.Id;
                    dgvHRList.Rows[rowIndex].Cells[1].Value = recruit.Name;
                    dgvHRList.Rows[rowIndex].Cells[2].Value = recruit.Contract_type;
                    dgvHRList.Rows[rowIndex].Cells[3].Value = recruit.Position;
                    dgvHRList.Rows[rowIndex].Cells[4].Value = recruit.Roles;
                    dgvHRList.Rows[rowIndex].Cells[5].Value = "• " + recruit.Status;
                    
                    if (recruit.Status == "Interviewed")
                    {
                        dgvHRList.Rows[rowIndex].Cells[5].Style.ForeColor = Color.FromArgb(69, 158, 26);
                    }
                    else if(recruit.Status == "Confirmed")
                    {
                        dgvHRList.Rows[rowIndex].Cells[5].Style.ForeColor = Color.Blue;
                    }
                    else if( recruit.Status == "Created")
                    {
                        dgvHRList.Rows[rowIndex].Cells[5].Style.ForeColor = Color.FromArgb(255, 212, 59);
                    }
                }
            }
            else dgvHRList.Rows.Clear();
        }

        public void ShowCmbDepartment(IEnumerable<DepartmentModel> departmentList)
        {
            cbDepartment.Items.Clear();
            foreach (var item in departmentList)
            {
                cbDepartment.Items.Add($"{item.Id} - {item.Name}");
            }    
        }

        public RecruitDialog ShowDialogToAdd()
        {

            RecruitDialog dialog = new RecruitDialog("Add");
            return dialog;
        }

        public RecruitDialog ShowDialogToEdit()
        {
            RecruitDialog dialog = new RecruitDialog("Edit");
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
                worksheet.Name = "Quản lý tuyển dụng";
                for (int i = 0; i < dataGridView1.ColumnCount - 2; i++)
                {
                    worksheet.Cells[1, i + 1] = dataGridView1.Columns[i].HeaderText;
                }
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    for (int j = 0; j < 6; j++)
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
            if(saveFile.ShowDialog() == DialogResult.OK)
            {
                ToExcel(dgvHRList, saveFile.FileName);
            }
        }
    }
}
