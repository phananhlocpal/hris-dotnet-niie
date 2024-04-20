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

namespace HRMngt._Repository.Calendar
{
    public class CalendarRepository: BaseRepository, ICalendarRepository
    {
        private string connectionString = BaseRepository.connectionString;

        // CRUD
        public void Add(CalendarModel calendarModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "insert into calendar (userID, date, register_checkIn, register_checkOut, status) values(@UserID, @Date, @Register_checkIn, @Register_checkOut, @Status)";
                command.Parameters.Add("@UserID", SqlDbType.Char).Value = calendarModel.UserId;
                command.Parameters.Add("@Date", SqlDbType.DateTime).Value = calendarModel.Date;
                command.Parameters.Add("@Register_checkIn", SqlDbType.Time).Value = calendarModel.CheckIn;
                command.Parameters.Add("@Register_checkOut", SqlDbType.Time).Value = calendarModel.CheckOut;
                command.Parameters.Add("@Status", SqlDbType.Char).Value = "Pending";
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
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT c.*, u.name AS user_name, d.name AS department_name\r\nFROM calendar c\r\nJOIN [users] u ON c.userID = u.userID\r\nJOIN department d ON u.departmentID = d.departmentID;\r\n ";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var calendarModel = new CalendarModel();
                        calendarModel.UserId = reader[0].ToString();
                        calendarModel.Date = (DateTime)reader[1];
                        calendarModel.CheckIn = (TimeSpan)reader[2];
                        calendarModel.CheckOut = (TimeSpan)reader[3];
                        if (calendarModel.RealCheckIn != null)
                            calendarModel.RealCheckIn = (TimeSpan)reader[4];
                        if (calendarModel.RealCheckOut != null)
                            calendarModel.RealCheckOut = (TimeSpan)reader[5];
                        calendarModel.Status = reader[8].ToString();
                        calendarModel.UserName = reader[9].ToString();
                        calendarModel.UserDepartment = reader[10].ToString();
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
                command.CommandText = "UPDATE calendar SET register_checkIn=@CheckIn, register_checkOut=@CheckOut, real_checkIn=@RealCheckIn, real_checkOut=@RealCheckOut, status=@Status WHERE (userID = @UserID and date = @Date)";
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
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        // ==========================================================================================================
        // LINQ 
        public CalendarModel LINQ_GetModelByUserIdNDate(IEnumerable<CalendarModel> calendarList, string userId, DateTime date)
        {
            var query = calendarList
                .Where(calendarModel => calendarModel.UserId == userId && calendarModel.Date.Date == date.Date.Date)
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
            var exists = calendarList.Any(calendarModel => calendarModel.Date == date);
            return exists;
        }

        public IEnumerable<CalendarModel> LINQ_Filter(IEnumerable<CalendarModel> calendarList, DateTime start, DateTime end, string departmentName, string status, string userId)
        {
            IEnumerable<CalendarModel> query = calendarList;

            if (!string.IsNullOrEmpty(userId))
            {
                query = query.Where(c => c.UserId == userId);
            }

            // Áp dụng các điều kiện lọc khác (nếu có)
            if (departmentName != "All")
            {
                query = query.Where(c => c.UserDepartment == departmentName);
            }
            if (status != "All")
            {
                query = query.Where(c => c.Status == status);
            }
            if (start != default(DateTime))
            {
                query = query.Where(c => c.Date >= start);
            }
            if (end != default(DateTime))
            {
                query = query.Where(c => c.Date <= end);
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
    }
}
