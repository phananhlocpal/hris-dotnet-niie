using HRMngt.Model;
using HRMngt.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRMngt._Repository.HR
{
    public class RecruitRepository : IRecruitRepository
    {
        private string connectionString = @"Data Source=localhost;Initial Catalog=HR;Integrated Security=True;";
        public void Add(RecruitModel recruitModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "insert into recruit (name, email, phone, address, sex, birthday, position, roles, note, status, contract_type, departmentID, managerID) " +
                    "values(@Name, @Email, @Phone, @Address, @Sex, @Birthday, @Position, @Roles, @Note, @Status,  @Contract_type, @departmentID, @managerID)";
                command.Parameters.Add("@Name", SqlDbType.NVarChar).Value = recruitModel.Name;
                command.Parameters.Add("@Email", SqlDbType.VarChar).Value = recruitModel.Email;
                command.Parameters.Add("@Phone", SqlDbType.VarChar, 10).Value = recruitModel.Phone;
                command.Parameters.Add("@Address", SqlDbType.NVarChar).Value = recruitModel.Address;
                command.Parameters.Add("@Sex", SqlDbType.NVarChar).Value = recruitModel.Sex;
                command.Parameters.Add("@Birthday", SqlDbType.DateTime).Value = recruitModel.Birthday;
                command.Parameters.Add("@Position", SqlDbType.NVarChar).Value = recruitModel.Position;
                command.Parameters.Add("@Roles", SqlDbType.NVarChar).Value = recruitModel.Roles;
                command.Parameters.Add("@Note", SqlDbType.NVarChar).Value = recruitModel.Note;
                command.Parameters.Add("@Status", SqlDbType.NVarChar).Value = recruitModel.Status;
                command.Parameters.Add("@Contract_type", SqlDbType.NVarChar).Value = recruitModel.Contract_type;
                command.Parameters.Add("@departmentID", SqlDbType.NVarChar).Value = recruitModel.DepartmentName;
                command.Parameters.Add("@managerID", SqlDbType.NVarChar).Value = recruitModel.ManagerName;

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
                command.CommandText = "delete from recruit where id_recruit = @Id";
                command.Parameters.Add("@Id", SqlDbType.Char).Value = id;
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void Edit(RecruitModel recruitModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "UPDATE recruit SET id_recruit = @recruitID, name = @Name, email = @Email, phone = @Phone, address = @Address, sex = @Sex, " +
                    "birthday = @Birthday, position = @Position, roles = @Roles, note = @Note, status = @Status, contract_type = @Contract_type, departmentID = @departmentID, managerID = @managerID WHERE id_recruit = @Id";
                command.Parameters.Add("@Id", SqlDbType.Char).Value = recruitModel.Id;
                command.Parameters.Add("@recruitID", SqlDbType.Char).Value = recruitModel.Id;
                command.Parameters.Add("@Name", SqlDbType.NVarChar).Value = recruitModel.Name;
                command.Parameters.Add("@Email", SqlDbType.VarChar).Value = recruitModel.Email;
                command.Parameters.Add("@Phone", SqlDbType.VarChar, 10).Value = recruitModel.Phone;
                command.Parameters.Add("@Address", SqlDbType.NVarChar).Value = recruitModel.Address;
                command.Parameters.Add("@Sex", SqlDbType.NVarChar).Value = recruitModel.Sex;
                command.Parameters.Add("@Birthday", SqlDbType.DateTime).Value = recruitModel.Birthday;
                command.Parameters.Add("@Position", SqlDbType.NVarChar).Value = recruitModel.Position;
                command.Parameters.Add("@Roles", SqlDbType.NVarChar).Value = recruitModel.Roles;
                command.Parameters.Add("@Note", SqlDbType.NVarChar).Value = recruitModel.Note;
                command.Parameters.Add("@Status", SqlDbType.NVarChar).Value = recruitModel.Status;
                command.Parameters.Add("@Contract_type", SqlDbType.NVarChar).Value = recruitModel.Contract_type;
                command.Parameters.Add("@departmentID", SqlDbType.NVarChar).Value = recruitModel.DepartmentName;
                command.Parameters.Add("@managerID", SqlDbType.NVarChar).Value = recruitModel.ManagerName;

                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public IEnumerable<RecruitModel> GetAll()
        {

            List<RecruitModel> listRecruit = new List<RecruitModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "select * from recruit where status != @Status";
                command.Parameters.Add("@Status", SqlDbType.NVarChar).Value = "On-boarding";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        RecruitModel recruit = new RecruitModel();
                        recruit.Id = reader[0].ToString();
                        recruit.Name = reader[1].ToString();
                        recruit.Email = reader[2].ToString();
                        recruit.Phone = reader[3].ToString();
                        recruit.Address = reader[4].ToString();
                        recruit.Sex = reader[5].ToString();
                        recruit.Birthday = (DateTime)reader[6];
                        recruit.Position = reader[7].ToString();
                        recruit.Roles = reader[8].ToString();
                        recruit.Note = reader[9].ToString();
                        recruit.Status = reader[10].ToString();
                        recruit.Contract_type = reader[11].ToString();
                        listRecruit.Add(recruit);
                    }
                }
                connection.Close();
            }
            return listRecruit;
        }

        public RecruitModel GetById(string id)
        {
            var recruit = new RecruitModel();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Select * from recruit where id_recruit = @id";
                command.Parameters.Add("@id", SqlDbType.Char).Value = id;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        recruit.Id = reader[0].ToString();
                        recruit.Name = reader[1].ToString();
                        recruit.Email = reader[2].ToString();
                        recruit.Phone = reader[3].ToString();
                        recruit.Address = reader[4].ToString();
                        recruit.Sex = reader[5].ToString();
                        recruit.Birthday = (DateTime)reader[6];
                        recruit.Position = reader[7].ToString();
                        recruit.Roles = reader[8].ToString();
                        recruit.Note = reader[9].ToString();
                        recruit.Status = reader[10].ToString();
                        recruit.Contract_type = reader[11].ToString();

                    }
                }
                connection.Close();
            }
            return recruit;
        }

        public string GetDepartmentID(string departmentName)
        {
            
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT departmentID from department where name = @Name";
                command.Parameters.Add("@Name", SqlDbType.NVarChar).Value = departmentName;
                

                command.ExecuteNonQuery();
                connection.Close();
            }
            return departmentName;
        }

        public string GetStatus(string id)
        {
            string status = "";
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT status from recruit where id_recruit = @Id";
                command.Parameters.Add("@Id", SqlDbType.Char).Value = id;
                command.Parameters.Add("@Status", SqlDbType.NVarChar).Value = status;

                command.ExecuteNonQuery();
                connection.Close();
            }
            return status;
        }

        public void UpdateRecruitToUser(RecruitModel recruitModel)
        {
            // Kiểm tra xem status có là "On-boarding" không
            if (recruitModel.Status == "On-boarding")
            {
                using (var connection = new SqlConnection(connectionString))
                using (var command = new SqlCommand())
                {
                    connection.Open();
                    command.Connection = connection;
                    command.CommandText = "INSERT INTO users (name, email, phone, address, birthday, deal_salary, username, password, managerID, departmentID, on_boarding, close_date, scan_contract, ava, sex, status, position, contract_type, roles) " +
                        "VALUES (@Name, @Email, @Phone, @Address, @Birthday, @Deal_salary, @Username, @Password, @ManagerID, @DepartmentID, @On_boarding, @Close_date, @Scan_contract, @Ava, @Sex, @Status, @Position, @Contract_type, @Roles)";
                    command.Parameters.Add("@Name", SqlDbType.NVarChar).Value = recruitModel.Name;
                    command.Parameters.Add("@Email", SqlDbType.VarChar).Value = recruitModel.Email;
                    command.Parameters.Add("@Phone", SqlDbType.VarChar, 10).Value = recruitModel.Phone;
                    command.Parameters.Add("@Address", SqlDbType.NVarChar).Value = recruitModel.Address;
                    command.Parameters.Add("@Birthday", SqlDbType.DateTime).Value = recruitModel.Birthday;
                    command.Parameters.Add("@Deal_salary", SqlDbType.Int).Value = 0;
                    command.Parameters.Add("@Username", SqlDbType.VarChar).Value = "";
                    command.Parameters.Add("@Password", SqlDbType.VarChar).Value = "";
                    command.Parameters.Add("@ManagerID", SqlDbType.Char).Value = recruitModel.ManagerName;
                    command.Parameters.Add("@DepartmentID", SqlDbType.Char).Value = recruitModel.DepartmentName;
                    command.Parameters.Add("@On_boarding", SqlDbType.DateTime).Value = DateTime.Now;
                    command.Parameters.Add("@Close_date", SqlDbType.DateTime).Value = DateTime.Now;
                    command.Parameters.Add("@Scan_contract", SqlDbType.NVarChar).Value = "";
                    command.Parameters.Add("@Ava", SqlDbType.VarChar).Value = "";
                    command.Parameters.Add("@Sex", SqlDbType.NVarChar).Value = recruitModel.Sex;
                    command.Parameters.Add("@Status", SqlDbType.NVarChar).Value = recruitModel.Status;
                    command.Parameters.Add("@Position", SqlDbType.NVarChar).Value = recruitModel.Position;
                    command.Parameters.Add("@Contract_type", SqlDbType.NVarChar).Value = recruitModel.Contract_type;
                    command.Parameters.Add("@Roles", SqlDbType.NVarChar).Value = recruitModel.Roles;

                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }


        public string UpdateStatus(string type, string id)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "UPDATE recruit SET status = @Status where id_recruit = @Id";
                command.Parameters.Add("@Id", SqlDbType.Char).Value = id;
                command.Parameters.Add("@Status", SqlDbType.NVarChar).Value = type;

                command.ExecuteNonQuery();
                connection.Close();
            }
            return type;
        }

        public string UpdateStatusAll(string type)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "UPDATE recruit SET status = @Status";
               
                command.Parameters.Add("@Status", SqlDbType.NVarChar).Value = type;

                command.ExecuteNonQuery();
                connection.Close();
            }
            return type;
        }
    }
}
