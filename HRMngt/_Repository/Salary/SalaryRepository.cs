using HRMngt.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMngt._Repository.Salary
{
    public class SalaryRepository : ISalaryRepository
    {
        private string connectionString = BaseRepository.connectionString;
        public SalaryRepository() { 

        }
        public void Add(SalaryModel salary)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "insert into salary (userID, get_month, get_year, workday, real_workday, welfare, thumb_total, ticket_total, tax, total_salary, res, status) " +
                    "values(@userID, @get_month, @get_year, @workday, @real_workday, @welfare, @thumb_total, @ticket_total, @tax, @total_salary, @res, @status)";
                command.Parameters.Add("@userID", SqlDbType.Char).Value = salary.UserId;
                command.Parameters.Add("@get_month", SqlDbType.Int).Value = salary.Month;
                command.Parameters.Add("@get_year", SqlDbType.Int).Value = salary.Year;
                command.Parameters.Add("@workday", SqlDbType.Int).Value = salary.Workday;
                command.Parameters.Add("@real_workday", SqlDbType.Int).Value = salary.Workday;
                command.Parameters.Add("@welfare", SqlDbType.Int).Value = salary.Welfare;
                command.Parameters.Add("@thumb_total", SqlDbType.Int).Value = salary.ThumbTotal;
                command.Parameters.Add("@ticket_total", SqlDbType.Int).Value = salary.TicketTotal;
                command.Parameters.Add("@tax", SqlDbType.Int).Value = salary.Tax;
                command.Parameters.Add("@total_salary", SqlDbType.Int).Value = salary.TotalSalary;
                command.Parameters.Add("@res", SqlDbType.NVarChar).Value = salary.Res;
                command.Parameters.Add("@status", SqlDbType.NVarChar).Value = salary.Status;
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void Delete(string id)
        {
            throw new NotImplementedException();
        }

        public void Edit(SalaryModel salary)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SalaryModel> GetAll()
        {
            throw new NotImplementedException();
        }


        public SalaryModel GetByID(string id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SalaryListModel> GetList()
        {
            var salaryList = new List<SalaryListModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT nv.userID, nv.name, l.get_month, l.get_year, nv.contract_type, nv.position, l.status AS l_salary_status FROM users AS nv JOIN salary AS l ON nv.userID = l.userID;";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var salaryModel = new SalaryListModel
                        {
                            UserId = reader[0].ToString(),
                            Name = reader[1].ToString(),
                            Month = (int)reader[2],
                            Year = (int)reader[3],
                            ContractType = reader[4].ToString(),
                            Position = reader[5].ToString(),
                            SalaryStatus = reader[6].ToString()
                        };

                        salaryList.Add(salaryModel);
                    }
                }
                connection.Close();
            }
            return salaryList;
        }
    }
}
