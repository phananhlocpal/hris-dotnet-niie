using HRMngt.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.ApplicationServices;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;

namespace HRMngt._Repository.Calendar
{
    public class CalendarRepository : BaseRepository, ICalendarRepository
    {

        // CRUD
        public void Add(CalendarModel calendarModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "insert into calendar (userID, date, register_checkIn, register_checkOut, status, requestId) values(@UserID, @Date, @Register_checkIn, @Register_checkOut, @Status, @RequestId)";
                command.Parameters.Add("@UserID", SqlDbType.Char).Value = calendarModel.UserId;
                command.Parameters.Add("@Date", SqlDbType.DateTime).Value = calendarModel.Date;
                command.Parameters.Add("@Register_checkIn", SqlDbType.Time).Value = calendarModel.CheckIn;
                command.Parameters.Add("@Register_checkOut", SqlDbType.Time).Value = calendarModel.CheckOut;
                command.Parameters.Add("@Status", SqlDbType.VarChar).Value = calendarModel.Status;
                command.Parameters.Add("@RequestId", SqlDbType.Int).Value = calendarModel.RequestId;
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void Delete(string userID, DateTime date)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "delete from calendar where (userID = @UserID and date = @Date)";
                command.Parameters.Add("@UserID", SqlDbType.Char).Value = userID;
                command.Parameters.Add("@Date", SqlDbType.DateTime).Value = date;
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public IEnumerable<CalendarModel> GetAll()
        {
            var calendarList = new List<CalendarModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand("SELECT c.*, u.*, d.name AS department_name, d.departmentID FROM calendar c JOIN [users] u ON c.userID = u.userID JOIN department d ON u.departmentID = d.departmentID", connection))
            {
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var calendarModel = new CalendarModel();
                        calendarModel.UserId = reader["userID"].ToString();
                        calendarModel.Date = (DateTime)reader["date"];
                        calendarModel.CheckIn = (TimeSpan)reader["register_checkIn"];
                        calendarModel.CheckOut = (TimeSpan)reader["register_checkOut"];
                        calendarModel.RealCheckIn = reader["real_CheckIn"] == DBNull.Value ? (TimeSpan?)null : (TimeSpan)reader["real_CheckIn"];
                        calendarModel.RealCheckOut = reader["real_CheckOut"] == DBNull.Value ? (TimeSpan?)null : (TimeSpan)reader["real_CheckOut"];
                        calendarModel.Status = reader["status"].ToString();
                        calendarModel.RequestId = Convert.ToInt32(reader["requestId"]);
                        calendarModel.UserName = reader["name"].ToString();
                        calendarModel.UserDepartment = reader["department_name"].ToString();
                        calendarModel.DepartmentId = reader["departmentID"].ToString();
                        calendarModel.ManagerId = reader["managerID"] == DBNull.Value ? reader["userID"].ToString() : reader["managerID"].ToString();
                        calendarList.Add(calendarModel);
                    }
                }
                connection.Close();
            }
            return calendarList;
        }

        public void Update(CalendarModel calendarModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "UPDATE calendar SET register_checkIn=@CheckIn, register_checkOut=@CheckOut, real_checkIn=@RealCheckIn, real_checkOut=@RealCheckOut, status=@Status, requestId=@RequestId WHERE (userID = @UserID and date = @Date)";
                command.Parameters.Add("@UserID", SqlDbType.Char).Value = calendarModel.UserId;
                command.Parameters.Add("@Date", SqlDbType.Date).Value = calendarModel.Date;
                command.Parameters.Add("@CheckIn", SqlDbType.Time).Value = calendarModel.CheckIn;
                command.Parameters.Add("@CheckOut", SqlDbType.Time).Value = calendarModel.CheckOut;
                // Kiểm tra và thiết lập giá trị cho realCheckIn và realCheckOut
                if (calendarModel.RealCheckIn.HasValue)
                {
                    command.Parameters.Add("@RealCheckIn", SqlDbType.Time).Value = calendarModel.RealCheckIn.Value;
                }
                else
                {
                    command.Parameters.Add("@RealCheckIn", SqlDbType.Time).Value = DBNull.Value;
                }

                if (calendarModel.RealCheckOut.HasValue)
                {
                    command.Parameters.Add("@RealCheckOut", SqlDbType.Time).Value = calendarModel.RealCheckOut.Value;
                }
                else
                {
                    command.Parameters.Add("@RealCheckOut", SqlDbType.Time).Value = DBNull.Value;
                }

                command.Parameters.Add("@Status", SqlDbType.Char).Value = calendarModel.Status;
                command.Parameters.Add("@RequestId", SqlDbType.Int).Value = calendarModel.RequestId;

                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public int GetRealWorkdayByMonthNYear(string userId, int month, int year)
        {
            int workdays = 0;

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM calendar WHERE userID = @UserID AND MONTH(date) = @Month AND YEAR(date) = @Year AND status IN ('Leave 1', 'Leave 2', 'Leave 3', 'Leave 4', 'Confirmed')";
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserID", userId);
                    command.Parameters.AddWithValue("@Month", month);
                    command.Parameters.AddWithValue("@Year", year);
                    workdays = (int)command.ExecuteScalar();
                }
                connection.Close();
            }
            return workdays;
        }

        public string GetAddressDepartment(string userID)
        {
            string departmentLocation = "";
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT DISTINCT department.location " +
                                      "FROM department " +
                                      "INNER JOIN users ON department.departmentID = users.departmentID " +
                                      "WHERE users.userID = @userID;";
                command.Parameters.Add("@userID", SqlDbType.Char).Value = userID;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        departmentLocation = reader["location"].ToString();
                    }
                }
                connection.Close();
            }

            return departmentLocation;
        }



        // ==========================================================================================================
        // LINQ 

        public CalendarModel LINQ_GetModelByUserIdNDate(IEnumerable<CalendarModel> calendarList, string userId, DateTime date)
        {
            var query = calendarList
                .Where(calendarModel => calendarModel.UserId == userId && calendarModel.Date.Date == date.Date)
                .ToList();
            return query.FirstOrDefault();
        }

        public IEnumerable<CalendarModel> LINQ_GetListByUserIDNPeriod(IEnumerable<CalendarModel> calendarList, string userId, DateTime start, DateTime end)
        {
            var query = calendarList
                .Where(calendarModel => calendarModel.UserId == userId && calendarModel.Date >= start && calendarModel.Date <= end)
                .ToList();
            return query;
        }
        public bool LINQ_checkExistDate(IEnumerable<CalendarModel> calendarList, DateTime date)
        {
            var existingCalendar = calendarList.FirstOrDefault(calendarModel => calendarModel.Date == date);
            return existingCalendar != null; // Trả về true nếu có mục thỏa mãn điều kiện
        }

        public IEnumerable<CalendarModel> LINQ_Filter(IEnumerable<CalendarModel> calendarList, DateTime start, DateTime end, string departmentId, string status, string userId)
        {
            var query = calendarList;
            query = query.Where(c => c.Date >= start && c.Date <= end);

            if (!string.IsNullOrEmpty(userId))
            {
                query = query.Where(c => c.UserId == userId);
            }

            // Áp dụng các điều kiện lọc khác (nếu có)
            if (departmentId != "All")
            {
                query = query.Where(c => c.DepartmentId == departmentId);
            }
            if (status != "All")
            {
                query = query.Where(c => c.Status == status);
            }

            return query.ToList();
        }

        public IEnumerable<CalendarModel> LINQ_GetListByPeriod(IEnumerable<CalendarModel> calendarList, DateTime start, DateTime end)
        {
            var query = calendarList
                .Where(calendarModel => calendarModel.Date >= start && calendarModel.Date <= end)
                .ToList();
            return query;
        }

        public IEnumerable<CalendarModel> LINQ_GetListByRequestId(IEnumerable<CalendarModel> calendarList, int requestId)
        {
            var query = calendarList
                .Where(calendarModel => calendarModel.RequestId == requestId)
                .ToList();
            return query;
        }

        public IEnumerable<CalendarModel> LINQ_GetListByUserID(IEnumerable<CalendarModel> calendarList, string userId)
        {
            var query = calendarList
                .Where(calendarModel => calendarModel.UserId == userId)
                .ToList();
            return query;
        }

        public IEnumerable<CalendarModel> LINQ_GetListByMonthNYear(IEnumerable<CalendarModel> calendarList, int month, int year)
        {
            var query = calendarList
                .Where(calendarModel => calendarModel.Date.Month == month && calendarModel.Date.Year == year)
                .ToList();
            return query;
        }

        public IEnumerable<CalendarModel> LINQ_GetListByManagerId(IEnumerable<CalendarModel> calendarList, string managerId)
        {
            var query = calendarList
                .Where(calendarModel => calendarModel.ManagerId == managerId)
                .ToList();
            return query;
        }

        public bool LINQ_CheckIndividualExistDate(IEnumerable<CalendarModel> calendarList, string userID, DateTime date)
        {
            var existingCalendar = calendarList.FirstOrDefault(calendarModel => calendarModel.Date == date && calendarModel.UserId == userID);
            return existingCalendar != null;
        }
    }

}
