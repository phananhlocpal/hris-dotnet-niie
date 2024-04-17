using HRMngt.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMngt._Repository.Calendar
{
    public class CalendarRepository:ICalendarRepository
    {
        private string connectionString = @"Data Source=localhost;Initial Catalog=HR;Integrated Security=True;";
        public void Add(CalendarModel calendarModel, string userID)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "insert into calendar (userID, date, register_checkIn, register_checkOut, status) values(@UserID, @Date, @Register_checkIn, @Register_checkOut, @Status)";
                command.Parameters.Add("@UserID", SqlDbType.Char).Value = userID;
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
                command.CommandText = "Select * from calendar ";
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
                        calendarList.Add(calendarModel);
                    }
                }
                connection.Close();
            }
            return calendarList;
        }

        public CalendarModel GetByUserIdNDate(string userID, DateTime date)
        {
            var calendarModel = new CalendarModel();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Select * from calendar where (userID = @UserID AND date = @Date)";
                command.Parameters.Add("@UserID", SqlDbType.Char).Value = userID;
                command.Parameters.Add("@Date", SqlDbType.DateTime).Value = date;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {

                        calendarModel.UserId = reader[0].ToString();
                        calendarModel.Date = (DateTime)reader[1];
                        calendarModel.CheckIn = (TimeSpan)reader[2];
                        calendarModel.CheckOut = (TimeSpan)reader[3];
                        if (calendarModel.RealCheckIn != null)
                            calendarModel.RealCheckIn = (TimeSpan)reader[4];
                        if (calendarModel.RealCheckOut != null)
                            calendarModel.RealCheckOut = (TimeSpan)reader[5];
                        calendarModel.Status = reader[8].ToString();
                    }
                }
                connection.Close();
            }
            return calendarModel;
        }

        public IEnumerable<CalendarModel> GetByUserIDNMonth(string userID, int month, int year)
        {
            List<CalendarModel> calendarList = new List<CalendarModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Select * from calendar where (userID = @UserID AND MONTH(date) = @Month AND YEAR(date) = @Year)";
                command.Parameters.Add("@UserID", SqlDbType.Char).Value = userID;
                command.Parameters.Add("@Month", SqlDbType.Int).Value = month;
                command.Parameters.Add("@Year", SqlDbType.Int).Value = year;
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
                        calendarList.Add(calendarModel);
                    }
                }
                connection.Close();
            }
            return calendarList;
        }

        public IEnumerable<CalendarModel> GetByUserIDNPeriod(string userID, DateTime monday, DateTime sunday)
        {
            List<CalendarModel> calendarList = new List<CalendarModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM calendar WHERE (userID = @UserID AND date >= @Monday AND date <= @Sunday)";
                command.Parameters.Add("@UserID", SqlDbType.Char).Value = userID;
                command.Parameters.Add("@Monday", SqlDbType.DateTime).Value = monday;
                command.Parameters.Add("@Sunday", SqlDbType.DateTime).Value = sunday;
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
                        calendarList.Add(calendarModel);
                    }
                }
                connection.Close();
            }
            return calendarList;
        }


        public void Update(CalendarModel calendarModel, string userID)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "UPDATE calendar SET register_checkIn=@CheckIn, register_checkOut=@CheckOut, real_checkIn=@RealCheckIn, real_checkOut=@RealCheckOut, status=@Status WHERE (userID = @UserID and date = @Date)";
                command.Parameters.Add("@UserID", SqlDbType.Char).Value = userID;
                command.Parameters.Add("@Date", SqlDbType.Date).Value = calendarModel.Date;
                command.Parameters.Add("@CheckIn", SqlDbType.Time).Value = calendarModel.CheckIn;
                command.Parameters.Add("@CheckOut", SqlDbType.Time).Value = calendarModel.CheckOut;
                command.Parameters.Add("@RealCheckIn", SqlDbType.Time).Value = calendarModel.RealCheckIn;
                command.Parameters.Add("@RealCheckOut", SqlDbType.Time).Value = calendarModel.RealCheckOut;
                command.Parameters.Add("@Status", SqlDbType.Char).Value = calendarModel.Status;
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public bool checkDate(DateTime date)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT COUNT(*) FROM calendar WHERE date = @Date;";
                command.Parameters.Add("@Date", SqlDbType.DateTime).Value = date.Date;

                int count = (int)command.ExecuteScalar();

                connection.Close();

                return count > 0;
            }
        }
    }
}
