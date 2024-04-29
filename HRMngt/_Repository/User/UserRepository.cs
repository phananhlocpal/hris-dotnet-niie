using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using HRMngt.Models;
using System.Web.UI.WebControls;
using System.Net.Mail;
using System.Net;
<<<<<<< HEAD
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
=======
using System.IO;
using System.Drawing;
using Microsoft.VisualBasic.ApplicationServices;
>>>>>>> hieu-new

namespace HRMngt._Repository
{
    public class UserRepository : BaseRepository, IUserRepository
    {
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
                    command.CommandText = "insert into users (name, email, phone, address, birthday, sex, position, deal_salary, managerID, departmentID, contract_type, on_boarding, close_date, scan_contract, note, status, role, username, password, ava) " +
                        "values(@Name, @Email, @Phone, @Address, @Birthday, @Sex, @Position, @Deal_salary, @ManagerID, @DepartmentID, @Contract_type, @On_boarding, @Close_date, @Scan_contract, @Note, @Status, @Role, @Username, @Password, @Ava)";
                    command.Parameters.Add("@Name", SqlDbType.NVarChar).Value = userModel.Name;
                    command.Parameters.Add("@Email", SqlDbType.VarChar).Value = userModel.Email;
                    command.Parameters.Add("@Phone", SqlDbType.VarChar, 10).Value = userModel.Phone;
                    command.Parameters.Add("@Address", SqlDbType.NVarChar).Value = userModel.Address;
                    command.Parameters.Add("@Birthday", SqlDbType.DateTime).Value = userModel.Birthday;
                    command.Parameters.Add("@Sex", SqlDbType.NVarChar).Value = userModel.Sex;
                    command.Parameters.Add("@Position", SqlDbType.NVarChar).Value = userModel.Position;
                    command.Parameters.Add("@Deal_salary", SqlDbType.Int).Value = userModel.Salary;
                    command.Parameters.Add("@ManagerID", SqlDbType.Char).Value = userModel.ManagerID;
                    command.Parameters.Add("@DepartmentID", SqlDbType.Char).Value = userModel.DepartmentID;
                    command.Parameters.Add("@Contract_type", SqlDbType.NVarChar).Value = userModel.Contract_type;
                    command.Parameters.Add("@On_boarding", SqlDbType.DateTime).Value = userModel.On_boarding;
                    command.Parameters.Add("@Close_date", SqlDbType.DateTime).Value = userModel.Close_date;
                    command.Parameters.Add("@Scan_contract", SqlDbType.NVarChar).Value = userModel.Scan_contract;
                    command.Parameters.Add("@Note", SqlDbType.VarChar).Value = userModel.Note;
                    command.Parameters.Add("@Status", SqlDbType.NVarChar).Value = userModel.Status;
                    command.Parameters.Add("@Role", SqlDbType.NVarChar).Value = userModel.Roles;
                    command.Parameters.Add("@Username", SqlDbType.VarChar).Value = userModel.Username;
                    command.Parameters.Add("@Password", SqlDbType.VarChar).Value = hash;
                    command.Parameters.Add("@Ava", SqlDbType.Image).Value = userModel.Photo;
                    

                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
            catch (Exception e)
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
                command.CommandText = "UPDATE users SET userID = @userID, name = @Name, email = @Email, phone = @Phone, address = @Address, birthday = @Birthday, sex = @Sex, position = @Position, deal_salary = @Deal_salary, " +
                    "managerID = @ManagerID, departmentID = @DepartmentID, contract_type = @Contract_type, on_boarding = @On_Boarding, close_date = @Close_date, scan_contract = @Scan_contract, note = @Note, status = @Status, " +
                    "role = @Role, username = @Username, password = @Password, ava = @Ava WHERE userID = @Id";
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
                command.Parameters.Add("@Note", SqlDbType.VarChar).Value = userModel.Note;
                command.Parameters.Add("@Sex", SqlDbType.NVarChar).Value = userModel.Sex;
                command.Parameters.Add("@Status", SqlDbType.NVarChar).Value = userModel.Status;
                command.Parameters.Add("@Position", SqlDbType.NVarChar).Value = userModel.Position;
                command.Parameters.Add("@Contract_type", SqlDbType.NVarChar).Value = userModel.Contract_type;
                if (userModel.Photo != null)
                {
                    command.Parameters.Add("@Ava", SqlDbType.Image).Value = userModel.Photo;
                }
                else
                {
                    command.Parameters.Add("@Ava", SqlDbType.Image).Value = DBNull.Value;
                }

                command.Parameters.Add("@Role", SqlDbType.NVarChar).Value = userModel.Roles;

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
                        userModel.Birthday = (DateTime)reader[5];
                        userModel.Sex = reader[6].ToString();
<<<<<<< HEAD
                        userModel.Position = reader[7].ToString().Trim();
                        userModel.Salary = int.Parse(reader[8].ToString());
=======
                        userModel.Position = reader[7].ToString();
                        userModel.Salary = reader[8].ToString();
>>>>>>> hieu-new
                        userModel.ManagerID = reader[9].ToString();
                        userModel.DepartmentID = reader[10].ToString();
                        userModel.Contract_type = reader[11].ToString();
                        userModel.On_boarding = (DateTime)reader[12];
                        userModel.Close_date = (DateTime)reader[13];
                        userModel.Scan_contract = reader[14].ToString();
                        userModel.Note = reader[15].ToString();
                        userModel.Status = reader[16].ToString();
                        userModel.Roles = reader[17].ToString();
                        userModel.Username = reader[18].ToString();
                        userModel.Password = reader[19].ToString();

                        // Kiểm tra nếu giá trị của cột "Photo" không phải là DBNull
                        if (reader[20] != DBNull.Value)
                        {
                            userModel.Photo = (byte[])reader[20];
                        }
                        else
                        {
                            // Xử lý trường hợp giá trị DBNull, ví dụ: gán một giá trị mặc định
                            userModel.Photo = new byte[0]; // hoặc null, tùy thuộc vào yêu cầu của bạn
                        }

                        userLists.Add(userModel);
                    }
                }
                connection.Close();
            }
            return userLists;
        }
        public IEnumerable<UserModel> GetAllRolesEmployee(string departmentID)
        {
            var userLists = new List<UserModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Select * from users where departmentID = @DepartmentID";
                command.Parameters.Add("@DepartmentID", SqlDbType.Char).Value = departmentID;
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
                        userModel.Sex = reader[6].ToString();
                        userModel.Position = reader[7].ToString();
                        userModel.Salary = reader[8].ToString();
                        userModel.ManagerID = reader[9].ToString();
                        userModel.DepartmentID = reader[10].ToString();
                        userModel.Contract_type = reader[11].ToString();
                        userModel.On_boarding = (DateTime)reader[12];
                        userModel.Close_date = (DateTime)reader[13];
                        userModel.Scan_contract = reader[14].ToString();
                        userModel.Note = reader[15].ToString();
                        userModel.Status = reader[16].ToString();
                        userModel.Roles = reader[17].ToString();
                        userModel.Username = reader[18].ToString();
                        userModel.Password = reader[19].ToString();

                        // Kiểm tra nếu giá trị của cột "Photo" không phải là DBNull
                        if (reader[20] != DBNull.Value)
                        {
                            userModel.Photo = (byte[])reader[20];
                        }
                        else
                        {
                            // Xử lý trường hợp giá trị DBNull, ví dụ: gán một giá trị mặc định
                            userModel.Photo = new byte[0]; // hoặc null, tùy thuộc vào yêu cầu của bạn
                        }

                        userLists.Add(userModel);
                    }
                }
                connection.Close();
            }
            return userLists;
        }

        public IEnumerable<UserModel> GetByValue()
        {
<<<<<<< HEAD
            var userModel = new UserModel();
            if (password != string.Empty && username != string.Empty)
            {
                using (var connection = new SqlConnection(connectionString))
                using (var command = new SqlCommand())
                {
                    connection.Open();
                    command.Connection = connection;
                    command.CommandText = "select * from users where username= @Username and password= @Password";
                    command.Parameters.Add("@Username", SqlDbType.VarChar).Value = username;
                    command.Parameters.Add("@Password", SqlDbType.VarChar).Value = password;
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
                            userModel.Sex = reader[6].ToString();
                            userModel.Position = reader[7].ToString().Trim();
                            userModel.Salary = int.Parse(reader[8].ToString());
                            if (reader.IsDBNull(9))
                                userModel.ManagerID = reader[0].ToString();
                            else
                                userModel.ManagerID = reader[9].ToString();
                            userModel.DepartmentID = reader[10].ToString();
                            userModel.Contract_type = reader[11].ToString();
                            userModel.On_boarding = (DateTime)reader[12];
                            if (reader[15] != DBNull.Value)
                                userModel.Close_date = (DateTime)reader[13];
                            userModel.Scan_contract = reader[14].ToString();
                            userModel.Note = reader[15].ToString();
                            userModel.Status = reader[16].ToString();
                            userModel.Roles = reader[17].ToString();
                            userModel.Username = reader[18].ToString();
                            userModel.Password = reader[19].ToString();
                            userModel.Ava = reader[20].ToString();

                        }
                    }
                    connection.Close();
                }
            }
            return userModel;
=======
            throw new NotImplementedException();
>>>>>>> hieu-new
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
                command.CommandText = "Select userID, name from users where role = @Role";
                command.Parameters.Add("@Role", SqlDbType.Char).Value = type;
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
        public UserModel LINQ_GetModelById(IEnumerable<UserModel> userList, string id)
        {
            var query = userList.Where(model => model.Id == id).ToList();
            return query.FirstOrDefault();
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
                        userModel.Sex = reader[6].ToString();
                        userModel.Position = reader[7].ToString();
                        userModel.Salary = reader[8].ToString();
                        userModel.ManagerID = reader[9].ToString();
                        userModel.DepartmentID = reader[10].ToString();
                        userModel.Contract_type = reader[11].ToString();
                        userModel.On_boarding = (DateTime)reader[12];
                        userModel.Close_date = (DateTime)reader[13];
                        userModel.Scan_contract = reader[14].ToString();
                        userModel.Note = reader[15].ToString();
                        userModel.Status = reader[16].ToString();
                        userModel.Roles = reader[17].ToString();
                        userModel.Username = reader[18].ToString();
                        userModel.Password = reader[19].ToString();
                        if (reader[20] != DBNull.Value)
                        {
                            userModel.Photo = (byte[])reader[20];
                        }
                        else
                        {
                            // Xử lý trường hợp giá trị DBNull, ví dụ: gán một giá trị mặc định
                            userModel.Photo = new byte[0]; // hoặc null, tùy thuộc vào yêu cầu của bạn
                        }

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

<<<<<<< HEAD
        public UserModel LINQ_getManagerById(IEnumerable<UserModel> userList, string id)
        {
            var query = userList
                .Where(userModel => userModel.Id == id)
                .ToList()
                .FirstOrDefault();
            var result = LINQ_GetModelById(userList, query.ManagerID);
            return result;
        }
=======
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
        public UserModel Authenticator(string username, string password)
        {
            var userModel = new UserModel();
            if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
            {
                try
                {
                    using (var connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        using (var command = new SqlCommand("SELECT * FROM users WHERE username = @username", connection))
                        {
                            command.Parameters.AddWithValue("@username", username);

                            using (var reader = command.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    string hashedPasswordFromDatabase = reader["password"].ToString();
                                    if (CheckPassword(password, hashedPasswordFromDatabase))
                                    {
                                        userModel.Id = reader[0].ToString();
                                        userModel.Name = reader[1].ToString();
                                        userModel.Email = reader[2].ToString();
                                        userModel.Phone = reader[3].ToString();
                                        userModel.Address = reader[4].ToString();
                                        userModel.Birthday = (DateTime)reader[5];
                                        userModel.Sex = reader[6].ToString();
                                        userModel.Position = reader[7].ToString();
                                        userModel.Salary = reader[8].ToString();
                                        userModel.ManagerID = reader[9].ToString();
                                        userModel.DepartmentID = reader[10].ToString();
                                        userModel.Contract_type = reader[11].ToString();
                                        userModel.On_boarding = (DateTime)reader[12];
                                        userModel.Close_date = (DateTime)reader[13];
                                        userModel.Scan_contract = reader[14].ToString();
                                        userModel.Note = reader[15].ToString();
                                        userModel.Status = reader[16].ToString();
                                        userModel.Roles = reader[17].ToString();
                                        userModel.Username = reader[18].ToString();
                                        userModel.Password = reader[19].ToString();
                                        connection.Close();
                                    }
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
            return userModel;
        }
        private bool CheckPassword(string inputPassword, string hashedPasswordFromDatabase)
        {
            return BCrypt.Net.BCrypt.Verify(inputPassword, hashedPasswordFromDatabase);
        }

        

        public IEnumerable<UserModel> Filter(IEnumerable<UserModel> userList, string department, string status)
        {
            var query = userList.Where(model => model.DepartmentID == department && model.Status == status);
            return query;
        }

        public IEnumerable<UserModel> LINQ_GetAllManager(IEnumerable<UserModel> userList, string userID)
        {
            var query = userList.Where(model => model.ManagerID == userID).ToList(); ;
            return query;
        }

        public IEnumerable<UserModel> LINQ_GetAllUser(IEnumerable<UserModel> userList, string departmentID)
        {
            var query = userList.Where(model => model.DepartmentID == departmentID).ToList(); ;
            return query;
        }

        
>>>>>>> hieu-new
    }
}
