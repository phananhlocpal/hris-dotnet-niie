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



        public IEnumerable<SalaryModel> GetAllByUserID(string userId)
        {
            List<SalaryModel> individualSalaryList = new List<SalaryModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Select * from salary where userID = @UserID)";
                command.Parameters.Add("@UserID", SqlDbType.Char).Value = userId;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var salaryModel = new SalaryModel();
                        salaryModel.UserId = reader[0].ToString();
                        salaryModel.Month = (int)reader[1];
                        salaryModel.Year = (int)reader[2];
                        salaryModel.Workday = (int)reader[3];
                        salaryModel.RealWorkday = (int)reader[4];
                        salaryModel.Welfare = (int)reader[5];
                        salaryModel.ThumbTotal = (int)reader[6];
                        salaryModel.TicketTotal = (int)reader[7];
                        salaryModel.Tax = (int)reader[8];
                        salaryModel.TotalSalary = (int)reader[9];
                        salaryModel.Status = reader[20].ToString();
                        individualSalaryList.Add(salaryModel);
                    }
                }
                connection.Close();
            }
            return individualSalaryList;
        }

        public SalaryModel GetByKey(string userId, int month, int year)
        {
            var salaryModel = new SalaryModel();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Select * from salary where (userID = @UserID AND get_month= @Month AND get_year = @Year)";
                command.Parameters.Add("@UserID", SqlDbType.Char).Value = userId;
                command.Parameters.Add("@Month", SqlDbType.Int).Value = month;
                command.Parameters.Add("@Year", SqlDbType.Int).Value = year;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        salaryModel.UserId = reader[0].ToString();
                        salaryModel.Month = (int)reader[1];
                        salaryModel.Year = (int)reader[2];
                        salaryModel.Workday = (int)reader[3];
                        salaryModel.RealWorkday = (int)reader[4];
                        salaryModel.Welfare = (int)reader[5];
                        salaryModel.ThumbTotal = (int)reader[6];
                        salaryModel.TicketTotal = (int)reader[7];
                        salaryModel.Tax = (int)reader[8];
                        salaryModel.TotalSalary = (int)reader[9];
                        salaryModel.Status = reader[20].ToString();
                    }
                }
                connection.Close();
            }
            return salaryModel;
        }

        public void Update(SalaryModel salaryModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "UPDATE salary SET workday=@Workday, real_workday=@RealWorkday, thumb_total=@ThumbTotal, ticket_total=@TicketTotal, tax=@Tax, total_salary=@TotalSalary, res=@Res, status=@Status WHERE (userID = @UserID AND get_month= @Month AND get_year = @Year)";
                command.Parameters.Add("@Workday", SqlDbType.Char).Value = salaryModel.Workday;
                command.Parameters.Add("@RealWorkday", SqlDbType.NVarChar).Value = salaryModel.RealWorkday;
                command.Parameters.Add("@ThumbTotal", SqlDbType.Int).Value = salaryModel.ThumbTotal;
                command.Parameters.Add("@TicketTotal", SqlDbType.Int).Value = salaryModel.TicketTotal;
                command.Parameters.Add("@Tax", SqlDbType.Int).Value = salaryModel.Tax;
                command.Parameters.Add("@TotalSalary", SqlDbType.Int).Value = salaryModel.TotalSalary;
                // Use ternary operator to handle null values for Response
                command.Parameters.Add("@Res", SqlDbType.NVarChar).Value = salaryModel.Res ?? (object)DBNull.Value;
                command.Parameters.Add("@Status", SqlDbType.NVarChar).Value = salaryModel.Status;
                command.Parameters.Add("@UserID", SqlDbType.Char).Value = salaryModel.UserId;
                command.Parameters.Add("@Month", SqlDbType.Int).Value = salaryModel.Month;
                command.Parameters.Add("@Year", SqlDbType.Int).Value = salaryModel.Year;
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        //INSERT INTO salary(userID, get_month, get_year, workday, real_workday, welfare, thumb_total, ticket_total, tax, total_salary, res, status)
        //SELECT
        //    u.userID,
        //    4 AS get_month,
        //    2024 AS get_year,
        //    22 AS workday,
        //    COUNT(c.real_checkIn) AS real_workday,
        //    0 AS welfare,
        //        COALESCE(SUM(CASE WHEN t.type = 'Thumb Up' THEN t.money ELSE 0 END), 0) AS thumb_total,
        //    COALESCE(SUM(CASE WHEN t.type = 'Ticket' THEN t.money ELSE 0 END), 0) AS ticket_total,
        //    0.1 * ((COUNT(c.real_checkIn) / 22) * u.deal_salary + 0 - COALESCE(SUM(CASE WHEN t.type = 'Thumb Up' THEN t.money ELSE 0 END), 0) - COALESCE(SUM(CASE WHEN t.type = 'Ticket' THEN t.money ELSE 0 END), 0)) AS tax,
        //    ((COUNT(c.real_checkIn) / 22) * u.deal_salary + 0 - COALESCE(SUM(CASE WHEN t.type = 'Thumb Up' THEN t.money ELSE 0 END), 0) - COALESCE(SUM(CASE WHEN t.type = 'Ticket' THEN t.money ELSE 0 END), 0) - 0.1 * ((COUNT(c.real_checkIn) / 22) * u.deal_salary + 0 - COALESCE(SUM(CASE WHEN t.type = 'Thumb Up' THEN t.money ELSE 0 END), 0) - COALESCE(SUM(CASE WHEN t.type = 'Ticket' THEN t.money ELSE 0 END), 0))) AS total_salary,
        //    '' AS res,
        //    'Unconfirm' AS status
        //FROM
        //    users u
        //JOIN
        //    calendar c ON u.userID = c.userID
        //        LEFT JOIN
        //    thumbticket t ON u.userID = t.id
        //WHERE
        //    u.status = 1
        //    AND c.status = 'Done'
        //    AND MONTH(c.date) = 4 AND YEAR(c.date) = 2024
        //    AND (t.status = 'Done' OR t.status IS NULL) -- Updated condition to handle NULL status
        //GROUP BY
        //    u.userID, u.deal_salary;
    }
}
