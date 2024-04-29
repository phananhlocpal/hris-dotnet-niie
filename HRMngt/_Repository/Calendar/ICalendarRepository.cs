using HRMngt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMngt._Repository.Calendar
{
    public interface ICalendarRepository
    {
        // CRUD
        void Add(CalendarModel calendarModel);
        void Update(CalendarModel calendarModel);
        void Delete(string userID, DateTime date);
        IEnumerable<CalendarModel> GetAll();

        int GetRealWorkdayByMonthNYear(string userId, int month, int year);

        // LINQ
        CalendarModel LINQ_GetModelByUserIdNDate(IEnumerable<CalendarModel> calendarList, string userId, DateTime date);
        IEnumerable<CalendarModel> LINQ_GetListByUserIDNPeriod(IEnumerable<CalendarModel> calendarList, string userId, DateTime monday, DateTime sunday);
        bool LINQ_checkExistDate(IEnumerable<CalendarModel> calendarList, DateTime date);
        IEnumerable<CalendarModel> LINQ_Filter(IEnumerable<CalendarModel> calendarList, DateTime start, DateTime end, string departmentId, string status, string userId);
        IEnumerable<CalendarModel> LINQ_GetListByPeriod(IEnumerable<CalendarModel> calendarList, DateTime start, DateTime end);
        IEnumerable<CalendarModel> LINQ_GetListByRequestId(IEnumerable<CalendarModel> calendarList, int requestId);
    }
}
