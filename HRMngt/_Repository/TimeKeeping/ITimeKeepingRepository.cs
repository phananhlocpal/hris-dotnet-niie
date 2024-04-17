using HRMngt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMngt._Repository.TimeKeeping
{
    public interface ITimeKeepingRepository
    {
        void Add(CalendarModel calendarModel, string userID);
        void Update(CalendarModel calendarModel, string userID);
        void Delete(string userID, DateTime date);
        IEnumerable<CalendarModel> GetAll();
        IEnumerable<CalendarModel> GetByUserIDNMonth(string userID, int month, int year);
        //DepartmentModel GetById(string id);

        IEnumerable<CalendarModel> GetByUserIDNPeriod(string userID, DateTime monday, DateTime sunday);

        CalendarModel GetByUserIdNDate(string userID, DateTime date);
        bool checkDate(DateTime date);
    }
}
