using HRMngt.Model;
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
                command.CommandText = "Select * from thumbticket ";
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
                        ThumbTicketList.Add(thumbTicketModel);
                    }
                }
                connection.Close();
            }
            return ThumbTicketList;
        }

        public ThumbTicketModel GetById(string id)
        {
            var thumbTicketModel = new ThumbTicketModel();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Select * from thumbticket where id = @Id ";
                command.Parameters.Add("@Id", SqlDbType.Char).Value = id;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
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
                    }
                }
                connection.Close();
            }
            return thumbTicketModel;
        }

        public IEnumerable<ThumbTicketModel> GetByUserId(string id)
        {
            var thumbTicketList = new List<ThumbTicketModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Select * from thumbticket where receiver = @Id ";
                command.Parameters.Add("@Id", SqlDbType.Char).Value = id;
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
                        thumbTicketList.Add(thumbTicketModel);
                    }
                }
                connection.Close();
            }
            return thumbTicketList;
        }

        public IEnumerable<ThumbTicketModel> GetByMonth(int month)
        {
            var thumbTicketList = new List<ThumbTicketModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                // Create command
                command.CommandText = "SELECT * FROM thumbticket WHERE MONTH(date) = @Month";
                command.Parameters.Add("@Month", SqlDbType.Int).Value = month;
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
                        thumbTicketList.Add(thumbTicketModel);
                    }
                }
            }

            if (thumbTicketList.Count > 0)
            {
                return thumbTicketList;
            }
            else
            {
                return null;
            }
        }


        public IEnumerable<ThumbTicketModel> GetByType(string type)
        {
            var thumbTicketList = new List<ThumbTicketModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                // Create command
                command.CommandText = "SELECT * FROM thumbticket WHERE type = @Type";
                command.Parameters.Add("@Type", SqlDbType.Char).Value = type;
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
                        thumbTicketList.Add(thumbTicketModel);
                    }
                }
            }

            if (thumbTicketList.Count > 0)
            {
                return thumbTicketList;
            }
            else
            {
                return null;
            }
        }

        public ThumbTicketModel LINQ_GetModelById(IEnumerable<ThumbTicketModel> thumbTicketList, string id)
        {
            var query = thumbTicketList.Where(model => model.Id == id).ToList();
            return query.FirstOrDefault();
        }

        public IEnumerable<ThumbTicketModel> LINQ_GetListByUserId(string id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ThumbTicketModel> LINQ_Filter(IEnumerable<ThumbTicketModel> thumbTicketList, int month, string type)
        {
            throw new NotImplementedException();
        }
    }
}
