using HRMngt._Repository.TimeKeeping;
using HRMngt.Models;
using HRMngt.Views.Dialogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMngt.Presenters
{
    public class TimeKeepingPresenter
    {
        private ITimeKeepingView view;
        private ITimeKeepingRepository repository;

        public TimeKeepingPresenter(ITimeKeepingView timeKeepingView, ITimeKeepingRepository timeKeepingRepository)
        {
            this.view = timeKeepingView;
            this.repository = timeKeepingRepository;
            IEnumerable<CalendarModel> calendarList = new List<CalendarModel>();
            this.view.ShowCalendarList(calendarList);
            this.view.Show();
        }
    }
}
