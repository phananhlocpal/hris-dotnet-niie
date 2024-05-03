using HRMngt.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRMngt._Repository.Salary
{
    public class SalaryRepository : ISalaryRepository
    {
        private string connectionString = BaseRepository.connectionString;
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
                if (salary.Res != null)
                    command.Parameters.Add("@res", SqlDbType.NVarChar).Value = salary.Res;
                else command.Parameters.Add("@res", SqlDbType.NVarChar).Value = DBNull.Value;
                command.Parameters.Add("@status", SqlDbType.NVarChar).Value = salary.Status;
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void Delete(string userId, int month, int year)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Delete from salary where userID = @UserId and get_month = @Month and get_year = @Year";
                command.Parameters.Add("@UserId", SqlDbType.Char).Value = userId;
                command.Parameters.Add("@Month", SqlDbType.Int).Value = month;
                command.Parameters.Add("@Year", SqlDbType.Int).Value = year;
                command.ExecuteNonQuery();
                connection.Close();
            }
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
                command.Parameters.Add("@Status", SqlDbType.VarChar).Value = salaryModel.Status;
                command.Parameters.Add("@UserID", SqlDbType.Char).Value = salaryModel.UserId;
                command.Parameters.Add("@Month", SqlDbType.Int).Value = salaryModel.Month;
                command.Parameters.Add("@Year", SqlDbType.Int).Value = salaryModel.Year;
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public IEnumerable<SalaryModel> GetAll()
        {
            List<SalaryModel> salaryList = new List<SalaryModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT salary.*, users.*, department.departmentID AS departmentId\r\nFROM salary\r\nINNER JOIN users ON salary.userID = users.userID\r\nINNER JOIN department ON department.departmentID = users.departmentID;\r\n";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var salaryModel = new SalaryModel();
                        salaryModel.UserId = reader[0].ToString();
                        salaryModel.Month = int.Parse(reader[1].ToString());
                        salaryModel.Year = int.Parse(reader[2].ToString());
                        salaryModel.Workday = int.Parse(reader[3].ToString());
                        salaryModel.RealWorkday = int.Parse(reader[4].ToString());
                        salaryModel.Welfare = int.Parse(reader[5].ToString());
                        salaryModel.ThumbTotal = int.Parse(reader[6].ToString());
                        salaryModel.TicketTotal = int.Parse(reader[7].ToString());
                        salaryModel.Tax = double.Parse(reader[8].ToString());
                        salaryModel.TotalSalary = double.Parse(reader[9].ToString());
                        salaryModel.Res = reader[10].ToString();
                        salaryModel.Status = reader[11].ToString();
                        salaryModel.UserName = reader["name"].ToString();
                        salaryModel.Contract_type = reader["contract_type"].ToString();
                        salaryModel.Position = reader["position"].ToString();
                        salaryModel.DepartmentId = reader["departmentId"].ToString();
                        salaryList.Add(salaryModel);
                    }
                }
                connection.Close();
            }
            return salaryList;
        }

        public SalaryModel LINQ_GetModelByPK(IEnumerable<SalaryModel> salaryList,string userId, int month, int year)
        {
            var query = salaryList
                .Where(salaryModel => salaryModel.UserId == userId && salaryModel.Month == month && salaryModel.Year == year)
                .ToList();
            return query.FirstOrDefault();
        }


        public bool LINQ_CheckExistSalary(IEnumerable<SalaryModel> salaryList, string userId, int month, int year)
        {
            var query = salaryList
                .Where(salaryModel => salaryModel.UserId == userId && salaryModel.Month == month && salaryModel.Year == year)
                .ToList();
            return query.Any(); 
        }

        public IEnumerable<SalaryModel> LINQ_GetListByMonthNYear(IEnumerable<SalaryModel> salaryList,  int month, int year)
        {
            var query = salaryList
                .Where(salaryModel => salaryModel.Month == month && salaryModel.Year == year)
                .ToList();
            return query;
        }

        public IEnumerable<SalaryModel> LINQ_Filter(IEnumerable<SalaryModel> salaryList, string departmentId, string status)
        {
            var query = salaryList;
            //MessageBox.Show(departmentId);
            if (departmentId != "All")
                query = query.Where(salaryModel => salaryModel.DepartmentId == departmentId);
            if (status != "All")
                query = query.Where(salaryModel => salaryModel.Status == status);
            return query.ToList();
        }


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