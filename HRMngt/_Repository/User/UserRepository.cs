using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using HRMngt.Model;
using System.Windows.Forms;
using HRMngt.Models;
using System.Web.UI.WebControls;
using System.Net.Mail;
using System.Net;

namespace HRMngt._Repository
{
    public class UserRepository : IUserRepository
    {
        string connectionString = "Data Source=localhost;Initial Catalog=HR;Integrated Security=True;Encrypt=False;";
        // Contructor
        public UserRepository()
        {
            
        }

        public void Add(UserModel userModel)
        {
            string salt = BCrypt.Net.BCrypt.GenerateSalt();
            string hash = BCrypt.Net.BCrypt.HashPassword(userModel.Password, salt);
            try
            {
                using (var connection = new SqlConnection(connectionString))
                using (var command = new SqlCommand())
                {
                    connection.Open();
                    command.Connection = connection;
                    command.CommandText = "insert into users (name, email, phone, address, birthday, deal_salary, username, password, managerID, departmentID, on_boarding, close_date, scan_contract, ava, sex, status, position, contract_type, photo, roles) " +
                        "values(@Name, @Email, @Phone, @Address, @Birthday, @Deal_salary, @Username, @Password, @ManagerID, @DepartmentID, @On_boarding, @Close_date, @Scan_contract, @Ava, @Sex, @Status, @Position, @Contract_type, @Photo, @Roles)";
                    command.Parameters.Add("@Name", SqlDbType.NVarChar).Value = userModel.Name;
                    command.Parameters.Add("@Email", SqlDbType.VarChar).Value = userModel.Email;
                    command.Parameters.Add("@Phone", SqlDbType.VarChar, 10).Value = userModel.Phone;
                    command.Parameters.Add("@Address", SqlDbType.NVarChar).Value = userModel.Address;
                    command.Parameters.Add("@Birthday", SqlDbType.DateTime).Value = userModel.Birthday;
                    command.Parameters.Add("@Deal_salary", SqlDbType.Int).Value = userModel.Salary;
                    command.Parameters.Add("@Username", SqlDbType.VarChar).Value = userModel.Username;
                    command.Parameters.Add("@Password", SqlDbType.VarChar).Value = hash;
                    command.Parameters.Add("@ManagerID", SqlDbType.Char).Value = userModel.ManagerID;
                    command.Parameters.Add("@DepartmentID", SqlDbType.Char).Value = userModel.DepartmentID;
                    command.Parameters.Add("@On_boarding", SqlDbType.DateTime).Value = userModel.On_boarding;
                    command.Parameters.Add("@Close_date", SqlDbType.DateTime).Value = userModel.Close_date;
                    command.Parameters.Add("@Scan_contract", SqlDbType.NVarChar).Value = userModel.Scan_contract;
                    command.Parameters.Add("@Ava", SqlDbType.VarChar).Value = userModel.Ava;
                    command.Parameters.Add("@Sex", SqlDbType.NVarChar).Value = userModel.Sex;
                    command.Parameters.Add("@Status", SqlDbType.NVarChar).Value = userModel.Status;
                    command.Parameters.Add("@Position", SqlDbType.NVarChar).Value = userModel.Position;
                    command.Parameters.Add("@Contract_type", SqlDbType.NVarChar).Value = userModel.Contract_type;
                    command.Parameters.Add("@Photo", SqlDbType.Image).Value = userModel.Photo;
                    command.Parameters.Add("@Roles", SqlDbType.NVarChar).Value = userModel.Roles;

                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
            catch(Exception e)
            {
                /*MessageBox.Show("Thêm nhân viên hiện tại đang gặp sự cố!, vui lòng thử lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);*/
                MessageBox.Show(e.ToString());
            }
        }

        

        public void Delete(string id)
        {
            try
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
            catch
            {
                MessageBox.Show("Nhân viên hiện tại đang xuất hiện ở bảng khác!, vui lòng không xóa", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Update(UserModel userModel)
        {
            string salt = BCrypt.Net.BCrypt.GenerateSalt();
            string hash = BCrypt.Net.BCrypt.HashPassword(userModel.Password, salt);
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "UPDATE users SET userID = @userID, name = @Name, email = @Email, phone = @Phone, address = @Address, birthday= @Birthday, deal_salary = @Deal_salary, username = @Username, password= @Password, managerID= @ManagerID, " +
                    "departmentID= @DepartmentID, on_boarding = @On_boarding, close_date = @Close_date, scan_contract = @Scan_contract, ava = @Ava, sex = @Sex, status = @Status, position = @Position, contract_type =@Contract_type, roles = @Roles WHERE userID = @Id";
                command.Parameters.Add("@Id", SqlDbType.Char).Value = userModel.Id;
                command.Parameters.Add("@userID", SqlDbType.Char).Value = userModel.Id;
                command.Parameters.Add("@Name", SqlDbType.NVarChar).Value = userModel.Name;
                command.Parameters.Add("@Email", SqlDbType.VarChar).Value = userModel.Email;
                command.Parameters.Add("@Phone", SqlDbType.VarChar, 10).Value = userModel.Phone;
                command.Parameters.Add("@Address", SqlDbType.NVarChar).Value = userModel.Address;
                command.Parameters.Add("@Birthday", SqlDbType.DateTime).Value = userModel.Birthday;
                command.Parameters.Add("@Deal_salary", SqlDbType.Int).Value = userModel.Salary;
                command.Parameters.Add("@Username", SqlDbType.VarChar).Value = userModel.Username;
                command.Parameters.Add("@Password", SqlDbType.VarChar).Value = hash;
                command.Parameters.Add("@ManagerID", SqlDbType.Char).Value = userModel.ManagerID;
                command.Parameters.Add("@DepartmentID", SqlDbType.Char).Value = userModel.DepartmentID;
                command.Parameters.Add("@On_boarding", SqlDbType.DateTime).Value = userModel.On_boarding;
                command.Parameters.Add("@Close_date", SqlDbType.DateTime).Value = userModel.Close_date;
                command.Parameters.Add("@Scan_contract", SqlDbType.NVarChar).Value = userModel.Scan_contract;
                command.Parameters.Add("@Ava", SqlDbType.VarChar).Value = userModel.Ava;
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
            var userLists = new List<UserModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Select * from users ";
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
                        userModel.Birthday =(DateTime) reader[5];
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
                        userLists.Add(userModel);
                    }
                }
                connection.Close();
            }
            return userLists;
        }

        public IEnumerable<UserModel> GetByValue()
        {
            throw new NotImplementedException();
        }

        public List<string> GetUserIdNName()
        {
            string type = "Admin";
            var UserIdNNameList = new List<string>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Select userID, name from users where roles = @Roles";
                command.Parameters.Add("@Roles", SqlDbType.Char).Value = type;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var userModel = new UserModel();
                        userModel.Id = reader[0].ToString();
                        userModel.Name = reader[1].ToString();
                        UserIdNNameList.Add($"{userModel.Id} - {userModel.Name}");
                    }
                }
                connection.Close();
            }
            return UserIdNNameList;
        }

        public string GetNameById(string id)
        {
            string name = "";
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Select name from users where userID = @userID";
                command.Parameters.Add("@userID", SqlDbType.Char).Value = id;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var userNameModel = new UserModel();
                        userNameModel.Name = reader[0].ToString();
                        name = userNameModel.Name;
                    }
                }
                connection.Close();
            }
            
            return name;
        }

        public string GetNameDepartmentById(string id)
        {
            string name = "";
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Select name from department where departmentID = @Id";
                command.Parameters.Add("@Id", SqlDbType.Char).Value = id;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        name = reader[0].ToString();
                    }
                }
                connection.Close();
            }

            return name;
        }
        public UserModel GetById(string id)
        {
            var userModel = new UserModel();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Select * from users where userID = @id";
                command.Parameters.Add("@id", SqlDbType.Char).Value = id;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
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

                    }
                }
                connection.Close();
            }
            return userModel;
        }

        public string RandomPasswords()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            Random random = new Random();
            string password = new string(Enumerable.Repeat(chars, 10).Select(s => s[random.Next(s.Length)]).ToArray());
            return password;
        }

        public void SendMail(string password, string email)
        {
            string from, pass, messageBody, to;
            MailMessage mailMessage = new MailMessage();
            to = email;
            from = "h2ltcdeveloper@gmail.com";
            pass = "uzmf nvjj nntl jnqm";
            messageBody = $"Mật khẩu của bạn là {password}";
            mailMessage.To.Add(to);
            mailMessage.From = new MailAddress(from);
            mailMessage.Body = messageBody;
            mailMessage.Subject = "Mật khẩu Tài Khoản";
            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
            smtpClient.EnableSsl = true;
            smtpClient.UseDefaultCredentials = false;
            smtpClient.Port = 587;
            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtpClient.Credentials = new NetworkCredential(from, pass);
            try
            {
                smtpClient.Send(mailMessage);
                MessageBox.Show("Mật khẩu đã được gửi thành công -_-");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public List<string> GetDepartmentIDName()
        {

            var departmentIDNameList = new List<string>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Select departmentID, name from department";

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var deparment = new DepartmentModel();
                        deparment.Id = reader[0].ToString();
                        deparment.Name = reader[1].ToString();
                        departmentIDNameList.Add($"{deparment.Id} - {deparment.Name}");
                    }
                }
                connection.Close();
            }
            return departmentIDNameList;
        }

        public void DeleteAll()
        {
            using (var connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string sqlQuery = "DELETE FROM users";
                    using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                    {
                        int rowsAffected = command.ExecuteNonQuery();
                        MessageBox.Show(rowsAffected.ToString() + " nhân viên đã xóa.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }
    }
}
