using HRMngt.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;

namespace HRMngt._Repository
{
    public class DepartmentRepository : BaseRepository, IDepartmentRepository
    {
        public DepartmentRepository()
        {

        }

        public void Add(DepartmentModel department)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "insert into department (name, phone, location, managerId) values(@Name, @Phone, @Location, @Manager)";
                /*command.Parameters.Add("@departmentID", SqlDbType.Char).Value = department.Id;*/
                command.Parameters.Add("@Name", SqlDbType.NVarChar).Value = department.Name;
                command.Parameters.Add("@Phone", SqlDbType.NVarChar, 10).Value = department.Phone;
                command.Parameters.Add("@Location", SqlDbType.NVarChar).Value = department.Location;
                command.Parameters.Add("@Manager", SqlDbType.NVarChar).Value = department.Manager;

                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void Delete(string id)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "delete from department where departmentID = @Id";
                command.Parameters.Add("@Id", SqlDbType.Char).Value = id;
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void Edit(DepartmentModel department)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "UPDATE department SET departmentID=@departmentID, name=@Name, phone=@Phone, location=@Location, managerID=@Manager WHERE departmentID = @Id";
                command.Parameters.Add("@Id", SqlDbType.Char).Value = department.Id;
                command.Parameters.Add("@departmentID", SqlDbType.Char).Value = department.Id;
                command.Parameters.Add("@Name", SqlDbType.NVarChar).Value = department.Name;
                command.Parameters.Add("@Phone", SqlDbType.NVarChar).Value = department.Phone;
                command.Parameters.Add("@Location", SqlDbType.NVarChar).Value = department.Location;
                command.Parameters.Add("@Manager", SqlDbType.NVarChar).Value = department.Manager;
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public IEnumerable<DepartmentModel> GetAll()
        {
            var departmentList = new List<DepartmentModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Select * from department ";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var departmentModel = new DepartmentModel();
                        departmentModel.Id = reader[0].ToString();
                        departmentModel.Name = reader[1].ToString();
                        departmentModel.Phone = reader[2].ToString();
                        departmentModel.Location = reader[3].ToString();
                        departmentModel.Manager = reader[4].ToString();
                        departmentList.Add(departmentModel);
                    }
                }
                connection.Close();
            }
            return departmentList;
        }


        public IEnumerable<DepartmentModel> LINQ_Filter(IEnumerable<DepartmentModel> departmentList, string manager)
        {
            var query = departmentList.AsEnumerable();
            if (manager != null)
                query = query.Where(model => model.Manager == manager);
            return query.ToList();
        }

        public DepartmentModel LINQ_GetModelById(IEnumerable<DepartmentModel> departmentList, string id)
        {
            var query = departmentList.Where(model => model.Id == id);
            return query.FirstOrDefault();
        }
    }
}
