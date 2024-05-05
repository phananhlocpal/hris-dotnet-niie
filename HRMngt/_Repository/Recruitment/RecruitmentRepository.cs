using HRMngt.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace HRMngt._Repository.Recruitment
{
    public class RecruitmentRepository : BaseRepository, IRecruitmentRepository
    {
        public void Add(UserModel userModel)
        {
            using(var connection = new SqlConnection(connectionString))
            using(var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "insert into users (name, email, phone, address, birthday, sex, position, managerID, departmentID, contract_type, note, status, role, username, password) " +
                    "values(@Name, @Email, @Phone, @Address, @Birthday, @Sex, @Position, @ManagerID, @DepartmentID, @Contract_type, @Note, @Status, @Role, @Username, @Password)";
                command.Parameters.Add("@Name", SqlDbType.NVarChar).Value = userModel.Name;
                command.Parameters.Add("@Email", SqlDbType.NVarChar).Value = userModel.Email;
                command.Parameters.Add("@Phone", SqlDbType.NVarChar).Value = userModel.Phone;
                command.Parameters.Add("@Address", SqlDbType.NVarChar).Value = userModel.Address;
                command.Parameters.Add("@Birthday", SqlDbType.NVarChar).Value = userModel.Birthday;
                command.Parameters.Add("@Sex", SqlDbType.NVarChar).Value = userModel.Sex;
                command.Parameters.Add("@Position", SqlDbType.NVarChar).Value = userModel.Position;
                command.Parameters.Add("@ManagerID", SqlDbType.NVarChar).Value = userModel.ManagerID;
                command.Parameters.Add("@DepartmentID", SqlDbType.NVarChar).Value = userModel.DepartmentID;
                command.Parameters.Add("@Contract_type", SqlDbType.NVarChar).Value = userModel.Contract_type;
                command.Parameters.Add("@Note", SqlDbType.NVarChar).Value = userModel.Note;
                command.Parameters.Add("@Status", SqlDbType.NVarChar).Value = userModel.Status;
                command.Parameters.Add("@Role", SqlDbType.NVarChar).Value = userModel.Roles;
                command.Parameters.Add("@Username", SqlDbType.NVarChar).Value = UserName(userModel.Name);
                command.Parameters.Add("@Password", SqlDbType.NVarChar).Value = Random();

                command.ExecuteNonQuery();
                connection.Close();
            }
        }
        public string Random()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            Random random = new Random();
            string password = new string(Enumerable.Repeat(chars, 10).Select(s => s[random.Next(s.Length)]).ToArray());
            return password;
        }
        public string UserName(string name)
        {
            return GenerateDepartmentID(name);
        }
        public string RemoveVietnameseSigns(string text)
        {
            text = text.ToLower();
            string signs = "áàảãạăắằẳẵặâấầẩẫậđéèẻẽẹêếềểễệíìỉĩịóòỏõọôốồổỗộơớờởỡợúùủũụưứừửữựýỳỷỹỵ";
            string replacements = "aaaaaaaaaaaaaaaaadeeeeeeeeeeeeeiiiiiooooooooooooooooouuuuuuuuuuuyyyyy";
            for (int i = 0; i < signs.Length; i++)
            {
                text = text.Replace(signs[i], replacements[i]);
            }

            return text;
        }


        public string GenerateDepartmentID(string fullName)
        {
            // Loại bỏ dấu và chuyển đổi thành chữ thường
            fullName = RemoveVietnameseSigns(fullName);

            // Chia chuỗi họ tên thành các phần tách bởi khoảng trắng
            string[] parts = fullName.Split(' ');

            // Tạo một StringBuilder để xây dựng chuỗi kết quả
            StringBuilder result = new StringBuilder();

            // Lấy phần đầu tiên là tên
            result.Append(parts[parts.Length - 1]); // Thêm tên vào

            // Nếu có họ và tên lót, thêm chữ cái đầu của họ vào
            if (parts.Length > 1)
            {
                for (int i = 0; i < parts.Length - 1; i++)
                {
                    result.Append(parts[i][0]); // Thêm chữ cái đầu của họ vào
                }
            }
            // Chuyển đổi kết quả thành chuỗi và trả về
            return result.ToString();
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

        public void Edit(UserModel userModel)
        {
            if (userModel.Status == "On-boarding")
            {
                using (var connection = new SqlConnection(connectionString))
                using (var command = new SqlCommand())
                {
                    connection.Open();
                    command.Connection = connection;
                    command.CommandText = "UPDATE users SET userID = @userID, name = @Name, email = @Email, phone = @Phone, address = @Address, birthday = @Birthday, sex = @Sex, position = @Position," +
                        "managerID = @ManagerID, departmentID = @DepartmentID, contract_type = @Contract_type, on_boarding = @On_boarding, close_date = @Close_date, note = @Note, status = @Status, " +
                        "role = @Role WHERE userID = @Id";
                    command.Parameters.Add("@Id", SqlDbType.Char).Value = userModel.Id;
                    command.Parameters.Add("@userID", SqlDbType.Char).Value = userModel.Id;
                    command.Parameters.Add("@Name", SqlDbType.NVarChar).Value = userModel.Name;
                    command.Parameters.Add("@Email", SqlDbType.VarChar).Value = userModel.Email;
                    command.Parameters.Add("@Phone", SqlDbType.VarChar, 10).Value = userModel.Phone;
                    command.Parameters.Add("@Address", SqlDbType.NVarChar).Value = userModel.Address;
                    command.Parameters.Add("@Birthday", SqlDbType.DateTime).Value = userModel.Birthday;
                    command.Parameters.Add("@ManagerID", SqlDbType.Char).Value = userModel.ManagerID;
                    command.Parameters.Add("@DepartmentID", SqlDbType.Char).Value = userModel.DepartmentID;
                    command.Parameters.Add("@Note", SqlDbType.VarChar).Value = userModel.Note;
                    command.Parameters.Add("@Sex", SqlDbType.NVarChar).Value = userModel.Sex;
                    command.Parameters.Add("@Status", SqlDbType.NVarChar).Value = userModel.Status;
                    command.Parameters.Add("@Position", SqlDbType.NVarChar).Value = userModel.Position;
                    command.Parameters.Add("@Contract_type", SqlDbType.NVarChar).Value = userModel.Contract_type;
                    command.Parameters.Add("@On_boarding", SqlDbType.NVarChar).Value = DateTime.Now;
                    command.Parameters.Add("@Close_date", SqlDbType.NVarChar).Value = DateTime.Now.AddYears(3);
                    command.Parameters.Add("@Role", SqlDbType.NVarChar).Value = userModel.Roles;

                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
            else
            {
                using (var connection = new SqlConnection(connectionString))
                using (var command = new SqlCommand())
                {
                    connection.Open();
                    command.Connection = connection;
                    command.CommandText = "UPDATE users SET userID = @userID, name = @Name, email = @Email, phone = @Phone, address = @Address, birthday = @Birthday, sex = @Sex, position = @Position," +
                        "managerID = @ManagerID, departmentID = @DepartmentID, contract_type = @Contract_type, note = @Note, status = @Status, " +
                        "role = @Role WHERE userID = @Id";
                    command.Parameters.Add("@Id", SqlDbType.Char).Value = userModel.Id;
                    command.Parameters.Add("@userID", SqlDbType.Char).Value = userModel.Id;
                    command.Parameters.Add("@Name", SqlDbType.NVarChar).Value = userModel.Name;
                    command.Parameters.Add("@Email", SqlDbType.VarChar).Value = userModel.Email;
                    command.Parameters.Add("@Phone", SqlDbType.VarChar, 10).Value = userModel.Phone;
                    command.Parameters.Add("@Address", SqlDbType.NVarChar).Value = userModel.Address;
                    command.Parameters.Add("@Birthday", SqlDbType.DateTime).Value = userModel.Birthday;
                    command.Parameters.Add("@ManagerID", SqlDbType.Char).Value = userModel.ManagerID;
                    command.Parameters.Add("@DepartmentID", SqlDbType.Char).Value = userModel.DepartmentID;
                    command.Parameters.Add("@Note", SqlDbType.VarChar).Value = userModel.Note;
                    command.Parameters.Add("@Sex", SqlDbType.NVarChar).Value = userModel.Sex;
                    command.Parameters.Add("@Status", SqlDbType.NVarChar).Value = userModel.Status;
                    command.Parameters.Add("@Position", SqlDbType.NVarChar).Value = userModel.Position;
                    command.Parameters.Add("@Contract_type", SqlDbType.NVarChar).Value = userModel.Contract_type;
                    command.Parameters.Add("@Role", SqlDbType.NVarChar).Value = userModel.Roles;

                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }

        public IEnumerable<UserModel> Filter(IEnumerable<UserModel> userList, string department, string status)
        {
            var query = userList;
            if (department != "All")
                query = query.Where(model => model.DepartmentID == department);
            if (status != "All")
                query = query.Where(model => model.Status == status);
            return query.ToList();
        }

        public IEnumerable<UserModel> GetAll()
        {
            var recruitmentList = new List<UserModel>();
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
                        userModel.Position = reader[7].ToString();
                        userModel.ManagerID = reader[9].ToString();
                        userModel.DepartmentID = reader[10].ToString();
                        userModel.Contract_type = reader[11].ToString();
                        userModel.Note = reader[15].ToString();
                        userModel.Status = reader[16].ToString();
                        userModel.Roles = reader[17].ToString();
                        userModel.Username = reader[18].ToString();
                        userModel.Password = reader[19].ToString();
                        recruitmentList.Add(userModel);
                    }
                }
                connection.Close();
            }
            return recruitmentList;
        }
        public UserModel LINQ_GetModelById(IEnumerable<UserModel> userList, string id)
        {
            var query = userList.Where(model => model.Id == id).ToList();
            return query.FirstOrDefault();
        }
        public void SendMail(string password, string email, string username, string name)
        {
            DateTime officialStartDate = DateTime.Now.AddDays(7);
            string day = officialStartDate.Day.ToString();
            string month = officialStartDate.Month.ToString();
            string year = officialStartDate.Year.ToString();
            string from, pass, to, subject;
            MailMessage mailMessage = new MailMessage();
            from = "h2ltcdeveloper@gmail.com";
            pass = "uzmf nvjj nntl jnqm";

            to = email;

            subject = "Chúc mừng bạn đã trở thành nhân viên chính thức!";
            string messageBody = $@"
    <html>
    <head>
        <style>
            /* Thêm các kiểu CSS để định dạng email */
            /* Ví dụ: */
            body {{
                font-family: Arial, sans-serif;
                background-color: #f4f4f4;
                padding: 20px;
            }}
            .container {{
                background-color: #fff;
                padding: 30px;
                border-radius: 10px;
                box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
            }}
            .message {{
                font-size: 16px;
                line-height: 1.5;
            }}
            .logo {{
                max-width: 150px;
                margin-bottom: 20px;
            }}
        </style>
    </head>
    <body>
        <div class='container'>
            <h1>Tập đoàn H2LTC Solutions Xin chào {name}!</h1>
            <p class='message'>Chúc mừng {name} đã trở thành nhân viên chính thức của Tập đoàn H2LTC Solutions.</p>
            <p class='message'>Bạn sẽ chính thức đi làm vào ngày {day} - {month} - {year}. Công ty rất vui vì sự có mặt của bạn</p>
            <p class='message'>Dưới đây là thông tin đăng nhập của bạn:</p>
            <ul>
                <li><strong>Tên đăng nhập:</strong> {username}</li>
                <li><strong>Mật khẩu:</strong> {password}</li>
            </ul>
            <p class='message'>Hãy đăng nhập vào hệ thống để bắt đầu sử dụng dịch vụ của chúng tôi.</p>
            <p class='message'>Trân trọng,</p>
            <p class='message'>Tập đoàn H2LTC Solutions</p>
        </div>
    </body>
    </html>
";

            mailMessage.To.Add(to);
            mailMessage.From = new MailAddress(from);
            mailMessage.Subject = subject;
            mailMessage.Body = messageBody;
            mailMessage.IsBodyHtml = true;
            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
            smtpClient.EnableSsl = true;
            smtpClient.UseDefaultCredentials = false;
            smtpClient.Port = 587;
            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtpClient.Credentials = new NetworkCredential(from, pass);
            try
            {
                smtpClient.Send(mailMessage);
                MessageBox.Show("Tài khoản - Mật khẩu đã được gửi về mail của người dùng -_-");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        public string LINQ_GetUsername(IEnumerable<UserModel> userList, string id)
        {
            var query = userList.Where(model => model.Id == id).Select(model => model.Username).FirstOrDefault();
            return query;
        }

        public string LINQ_GetPassword(IEnumerable<UserModel> userList, string id)
        {
            var query = userList.Where(model => model.Id == id).Select(model => model.Password).FirstOrDefault();
            return query;
        }
    }
}
