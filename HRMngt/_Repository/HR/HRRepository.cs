using HRMngt.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMngt._Repository.HR
{
    public class HRRepository : BaseRepository, IHRRepository
    {
        private string connectionString = BaseRepository.connectionString;
        public void Add(UserModel userModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "insert into users (name, email, phone, address, birthday, username, password, note,sex, status, position, contract_type, roles) " +
                    "values(@Name, @Email, @Phone, @Address, @Birthday, @Username, @Password, @Note, @Sex, @Status, @Position, @Contract_type, @Roles)";
                command.Parameters.Add("@Name", SqlDbType.NVarChar).Value = userModel.Name;
                command.Parameters.Add("@Email", SqlDbType.VarChar).Value = userModel.Email;
                command.Parameters.Add("@Phone", SqlDbType.VarChar, 10).Value = userModel.Phone;
                command.Parameters.Add("@Address", SqlDbType.NVarChar).Value = userModel.Address;
                command.Parameters.Add("@Birthday", SqlDbType.DateTime).Value = userModel.Birthday;
                command.Parameters.Add("@Username", SqlDbType.VarChar).Value = "";
                command.Parameters.Add("@Password", SqlDbType.VarChar).Value = "";
                command.Parameters.Add("@Note", SqlDbType.NVarChar).Value = userModel.Note;
                command.Parameters.Add("@Sex", SqlDbType.NVarChar).Value = userModel.Sex;
                command.Parameters.Add("@Status", SqlDbType.NVarChar).Value = userModel.Status;
                command.Parameters.Add("@Position", SqlDbType.NVarChar).Value = userModel.Position;
                command.Parameters.Add("@Contract_type", SqlDbType.NVarChar).Value = userModel.Contract_type;
                command.Parameters.Add("@Roles", SqlDbType.NVarChar).Value = userModel.Roles;
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
                command.CommandText = "delete from users where userID = @Id";
                command.Parameters.Add("@Id", SqlDbType.Char).Value = id;
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void Edit(UserModel userModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "UPDATE users SET userID = @userID, name = @Name, email = @Email, phone = @Phone, address = @Address, birthday= @Birthday, " +
                    "note = @Note, sex = @Sex, status = @Status, position = @Position, contract_type =@Contract_type, roles = @Roles WHERE userID = @Id";
                command.Parameters.Add("@Id", SqlDbType.Char).Value = userModel.Id;
                command.Parameters.Add("@userID", SqlDbType.Char).Value = userModel.Id;
                command.Parameters.Add("@Name", SqlDbType.NVarChar).Value = userModel.Name;
                command.Parameters.Add("@Email", SqlDbType.VarChar).Value = userModel.Email;
                command.Parameters.Add("@Phone", SqlDbType.VarChar, 10).Value = userModel.Phone;
                command.Parameters.Add("@Address", SqlDbType.NVarChar).Value = userModel.Address;
                command.Parameters.Add("@Birthday", SqlDbType.DateTime).Value = userModel.Birthday;
                command.Parameters.Add("@Note", SqlDbType.DateTime).Value = userModel.Birthday;
                command.Parameters.Add("@Sex", SqlDbType.NVarChar).Value = userModel.Sex;
                command.Parameters.Add("@Status", SqlDbType.NVarChar).Value = userModel.Status;
                command.Parameters.Add("@Position", SqlDbType.NVarChar).Value = userModel.Position;
                command.Parameters.Add("@Contract_type", SqlDbType.NVarChar).Value = userModel.Contract_type;
                command.Parameters.Add("@Roles", SqlDbType.NVarChar).Value = userModel.Roles;

                command.ExecuteNonQuery();
                connection.Close();
            }
        }
        public IEnumerable<UserModel> GetAll()
        {
            string note = "";
            List<UserModel> listRecruit = new List<UserModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "select * from users where note != @Note";
                command.Parameters.Add("@Note", SqlDbType.NVarChar).Value = note;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var userModel = new UserModel();
                        userModel.Id = reader[0].ToString();
                        userModel.Name = reader[1].ToString();
                        userModel.Email = reader[2].ToString();
                        userModel.Phone = reader[3].ToString();
                        userModel.Address = reader[4].ToString();
                        userModel.Birthday = (DateTime)reader[5];
                        userModel.Salary = reader[6].ToString();
                        userModel.Username = reader[7].ToString();
                        userModel.Password = reader[8].ToString();
                        userModel.ManagerID = reader[9].ToString();
                        userModel.DepartmentID = reader[10].ToString();
                        userModel.On_boarding = (DateTime)reader[11];
                        userModel.Close_date = (DateTime)reader[12];
                        userModel.Scan_contract = reader[13].ToString();
                        userModel.Note = reader[14].ToString();
                        userModel.Ava = reader[15].ToString();
                        userModel.Sex = reader[16].ToString();
                        userModel.Status = reader[17].ToString();
                        userModel.Position = reader[18].ToString();
                        userModel.Contract_type = reader[19].ToString();
                        userModel.Roles = reader[21].ToString();
                        listRecruit.Add(userModel);
                    }
                }
                connection.Close();
            }
            return listRecruit;
        }
    }
}
