using HRMngt.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.Design;
using Microsoft.VisualBasic.ApplicationServices;

namespace HRMngt._Repository.Request
{
    public class RequestRepository : IRequestRepository
    {
        private string connectionString = BaseRepository.connectionString;
        public RequestModel Add(RequestModel requestModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "INSERT INTO request (type, time, sender, approver, status) VALUES (@Type, @Time, @Sender, @Approver, @Status); SELECT SCOPE_IDENTITY();";
                command.Parameters.Add("@Type", SqlDbType.VarChar).Value = requestModel.Type;
                command.Parameters.Add("@Time", SqlDbType.DateTime).Value = requestModel.Time;
                command.Parameters.Add("@Sender", SqlDbType.Char).Value = requestModel.Sender;
                command.Parameters.Add("@Approver", SqlDbType.Char).Value = requestModel.Approver;
                command.Parameters.Add("@Status", SqlDbType.Bit).Value = 0;

                // Execute the command to insert the data and retrieve the new ID
                int newId = Convert.ToInt32(command.ExecuteScalar());

                connection.Close();

                // Update the RequestModel with the new ID
                requestModel.Id = newId;

                return requestModel;
            }
        }

        public void Delete(int id)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "delete from request where id = @Id";
                command.Parameters.Add("@Id", SqlDbType.Int).Value = id;
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public IEnumerable<RequestModel> GetAll()
        {
            var requestList = new List<RequestModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "select * from request";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        RequestModel requestModel = new RequestModel();
                        requestModel.Id = int.Parse(reader[0].ToString());
                        requestModel.Type = reader[1].ToString();
                        requestModel.Time = (DateTime)reader[2];
                        requestModel.Sender = reader[3].ToString();
                        requestModel.Approver = reader[4].ToString();
                        requestModel.Status = reader.GetBoolean(5) ? 1 : 0;
                        requestList.Add(requestModel);
                    }
                }
                connection.Close();
            }
            return requestList;
        }

        public void Update(RequestModel requestModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "UPDATE request SET status=@Status where id = @Id";
                command.Parameters.Add("@Status", SqlDbType.Int).Value = requestModel.Status;
                command.Parameters.Add("@Id", SqlDbType.Char).Value = requestModel.Id;
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public IEnumerable<RequestModel> LINQ_GetListByApproverId(IEnumerable<RequestModel> requestList, string approverId)
        {
            var query = requestList
                .Where(requestModel => requestModel.Approver == approverId)
                .ToList();
            return query;
        }

        public IEnumerable<RequestModel> LINQ_Filter(IEnumerable<RequestModel> requestList, DateTime time, int status, string type, string senderId)
        {
            var query = requestList.AsEnumerable();
            query = query.Where(requestModel => requestModel.Time.Month == time.Month && requestModel.Time.Year == time.Year);

            if (status != -1)
            {
                query = query.Where(requestModel => requestModel.Status == status);
            }
            if (type != "All")
            {
                query = query.Where(requestModel => requestModel.Type == type);

            }
            if (senderId != "")
            {
                query = query.Where(requestModel => requestModel.Sender == senderId);
            }

            return query.ToList();
        }

        public RequestModel LINQ_GetModelById(IEnumerable<RequestModel> requestList, int id)
        {
            var query = requestList
                .Where(requestModel => requestModel.Id == id)
                .ToList();
            return query.FirstOrDefault();
        }
    }
}
