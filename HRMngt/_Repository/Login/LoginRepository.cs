using HRMngt.Model;
using HRMngt.Models;
using HRMngt.View;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Configuration;
using System.Windows.Forms;
using System.Xml.Linq;

namespace HRMngt._Repository
{
    public class LoginRepository : ILoginRepository
    {
        string connectionString = @"Data Source=localhost;Initial Catalog=HR;Integrated Security=True;Encrypt=False;";

        public LoginRepository()
        {

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

        public string Login(string username, string password)
        {
            string id = "";
            if (password != string.Empty || username != string.Empty)
            {
                using (var connection = new SqlConnection(connectionString))
                using (var command = new SqlCommand())
                {
                    connection.Open();
                    command.Connection = connection;
                    command.CommandText = "select * from users where username='" + username + "' and password='" + password + "'";
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            id = reader[0].ToString();
                        }
                    }
                    connection.Close();
                }
            }
            return id;
        }
    }
}
      
