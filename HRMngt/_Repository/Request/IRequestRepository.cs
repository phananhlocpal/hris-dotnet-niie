using HRMngt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMngt._Repository.Request
{
    public interface IRequestRepository
    {
        // CRUD
        RequestModel Add(RequestModel requestModel);
        void Update(RequestModel requestModel);
        void Delete(int id);
        IEnumerable<RequestModel> GetAll();

        // LINQ
        IEnumerable<RequestModel> LINQ_GetListByApproverId(IEnumerable<RequestModel> requestList, string approverId);
        IEnumerable<RequestModel> LINQ_Filter(IEnumerable<RequestModel> requestList, DateTime time, int status, string senderId);
        RequestModel LINQ_GetModelById(IEnumerable<RequestModel> requestList, int id);
    }
}
