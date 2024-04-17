using HRMngt.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMngt._Repository.IndividualSalary
{
    public class IndividualSalaryRepository : IIndividualSalaryRepository
    {
        private string connectionString = @"Data Source=localhost;Initial Catalog=HR;Integrated Security=True;";

        public IndividualSalaryRepository()
        {

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
