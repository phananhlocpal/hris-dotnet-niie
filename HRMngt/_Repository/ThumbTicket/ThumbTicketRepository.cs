using HRMngt._Repository;
using HRMngt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace HRMngt._Repository
{
    public class ThumbTicketRepository : IThumbTicketRepository
    {
        private string connectionString = BaseRepository.connectionString;

        public void Add(ThumbTicketModel thumbTicketModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "insert into thumbticket (Type, Date, Sender, Receiver, Reason, Money, Status) values(@Type, @Date, @Sender, @Receiver, @Reason, @Money, @Status)";
                command.Parameters.Add("@Type", SqlDbType.NVarChar).Value = thumbTicketModel.Type;
                command.Parameters.Add("@Date", SqlDbType.DateTime).Value = thumbTicketModel.Date;
                command.Parameters.Add("@Sender", SqlDbType.Char).Value = thumbTicketModel.Sender;
                command.Parameters.Add("@Receiver", SqlDbType.Char).Value = thumbTicketModel.Receiver;
                command.Parameters.Add("@Reason", SqlDbType.NVarChar).Value = thumbTicketModel.Reason;
                command.Parameters.Add("@Money", SqlDbType.Int).Value = thumbTicketModel.Money;
                command.Parameters.Add("@Status", SqlDbType.NVarChar).Value = "Done";
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void Delete(string id)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "delete from thumbticket where id = @Id";
                command.Parameters.Add("@Id", SqlDbType.Char).Value = id;
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void Update(ThumbTicketModel thumbTicketModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "UPDATE thumbticket SET reason=@Reason, money=@Money, complain=@Complain, response=@Response, status=@Status WHERE id = @Id";
                command.Parameters.Add("@Id", SqlDbType.Char).Value = thumbTicketModel.Id;
                command.Parameters.Add("@Reason", SqlDbType.NVarChar).Value = thumbTicketModel.Reason;
                command.Parameters.Add("@Money", SqlDbType.Int).Value = thumbTicketModel.Money;
                // Use ternary operator to handle null values for Complain and Response
                command.Parameters.Add("@Complain", SqlDbType.NVarChar).Value = thumbTicketModel.Complain ?? (object)DBNull.Value;
                command.Parameters.Add("@Response", SqlDbType.NVarChar).Value = thumbTicketModel.Response ?? (object)DBNull.Value;
                command.Parameters.Add("@Status", SqlDbType.NVarChar).Value = thumbTicketModel.Status;
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public IEnumerable<ThumbTicketModel> GetAll()
        {
            var ThumbTicketList = new List<ThumbTicketModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Select * from thumbticket, users where thumbticket.receiver = users.userID";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var thumbTicketModel = new ThumbTicketModel();
                        thumbTicketModel.Id = reader[0].ToString();
                        thumbTicketModel.Type = reader[1].ToString();
                        thumbTicketModel.Date = (DateTime)reader[2];
                        thumbTicketModel.Sender = reader[3].ToString();
                        thumbTicketModel.Receiver = reader[4].ToString();
                        thumbTicketModel.Reason = reader[5].ToString();
                        thumbTicketModel.Money = (int)reader[6];
                        thumbTicketModel.Complain = reader[7].ToString();
                        thumbTicketModel.Response = reader[8].ToString();
                        thumbTicketModel.Status = reader[9].ToString();
                        thumbTicketModel.ManagerID = reader["managerId"].ToString();
                        ThumbTicketList.Add(thumbTicketModel);
                    }
                }
                connection.Close();
            }
            return ThumbTicketList;
        }

        public int GetThumbTotalByMonthNYear(string userId, int month, int year)
        {
            int thumbTotal = 0;
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT SUM(money) AS total_bonus\r\nFROM thumbticket\r\nWHERE type = 'Thumb Up'\r\nAND MONTH(date) = @Month\r\nAND YEAR(date) = @Year\r\nAND receiver = @UserId\r\nAND status = 'Done';\r\n";
                command.Parameters.Add("@Month", SqlDbType.Int).Value = month;
                command.Parameters.Add("@Year", SqlDbType.Int).Value = year;
                command.Parameters.Add("@UserId", SqlDbType.Char).Value = userId;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        if (!reader.IsDBNull(0))
                        {
                            thumbTotal = Convert.ToInt32(reader[0]);
                        }
                    }

                }
                connection.Close();
            }
            return thumbTotal;
        }

        public int GetTicketTotalByMonthNYear(string userId, int month, int year)
        {
            int ticketTotal = 0;
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT SUM(money) AS total_ticket\r\nFROM thumbticket\r\nWHERE type = 'Ticket'\r\nAND MONTH(date) = @Month\r\nAND YEAR(date) = @Year\r\nAND receiver = @UserId\r\nAND status = 'Done';\r\n";
                command.Parameters.Add("@Month", SqlDbType.Int).Value = month;
                command.Parameters.Add("@Year", SqlDbType.Int).Value = year;
                command.Parameters.Add("@UserId", SqlDbType.Char).Value = userId;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        if (!reader.IsDBNull(0))
                        {
                            ticketTotal = Convert.ToInt32(reader[0]);
                        }
                    }
                }
                connection.Close();
            }
            return ticketTotal;
        }

        public IEnumerable<ThumbTicketModel> LINQ_GetListById(IEnumerable<ThumbTicketModel> thumbTicketList, string id)
        {
            var query = thumbTicketList
                .Where(thumbTicketModel => thumbTicketModel.Id == id)
                .ToList();
            return query;
        }

        public IEnumerable<ThumbTicketModel> LINQ_GetListByUserId(IEnumerable<ThumbTicketModel> thumbTicketList, string id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ThumbTicketModel> LINQ_Filter(IEnumerable<ThumbTicketModel> thumbTicketList, string userId, int month, int year, string type)
        {
            var query = thumbTicketList;
            query = query.Where(model => model.Date.Year == year && model.Date.Month == month);
            if (userId != "")
                query = query.Where(thumbTicketModel => thumbTicketModel.Receiver == userId);
            if (type != "All")
                query = query.Where(model => model.Type == type);
            return query.ToList();
        }

        public ThumbTicketModel LINQ_GetModelById(IEnumerable<ThumbTicketModel> thumbTicketList, string id)
        {
            var query = thumbTicketList
                .Where(thumbTicketModel => thumbTicketModel.Id == id)
                .ToList();
            return query.FirstOrDefault();
        }

        public IEnumerable<ThumbTicketModel> LINQ_GetListByManager(IEnumerable<ThumbTicketModel> thumbTicketList, string managerId)
        {
            var query = thumbTicketList
                .Where(thumbTicketModel => thumbTicketModel.ManagerID == managerId);
            return query.ToList();
        }
    }
}
