using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRMngt.Models;
using Microsoft.VisualBasic.ApplicationServices;

namespace HRMngt._Repository
{
    public interface IThumbTicketRepository
    {
        void Add(ThumbTicketModel thumbTicketModel);
        void Update(ThumbTicketModel thumbTicketModel);
        void Delete(string id);
        IEnumerable<ThumbTicketModel> GetAll();

        // LINQ
        ThumbTicketModel LINQ_GetModelById(IEnumerable<ThumbTicketModel> thumbTicketList, string id);
        IEnumerable<ThumbTicketModel> LINQ_GetListById(IEnumerable<ThumbTicketModel> thumbTicketList, string id);
        IEnumerable<ThumbTicketModel> LINQ_GetListByUserId(IEnumerable<ThumbTicketModel> thumbTicketList, string id);
        IEnumerable<ThumbTicketModel> LINQ_Filter(IEnumerable<ThumbTicketModel> thumbTicketList, string userId, int month, int year, string type);
        IEnumerable<ThumbTicketModel> LINQ_GetListByManager(IEnumerable<ThumbTicketModel> thumbTicketList, string managerId);
        int GetThumbTotalByMonthNYear(string userId, int month, int year);
        int GetTicketTotalByMonthNYear(string userId, int month, int year);
    }
}
