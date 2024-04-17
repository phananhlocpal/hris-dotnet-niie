﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMngt.Models
{
    public class CalendarModel
    {
        private string userId;
        private DateTime date;
        private TimeSpan checkIn;
        private TimeSpan checkOut;
        private TimeSpan? realCheckIn;
        private TimeSpan? realCheckOut;
        private string status;

        // Encapsulate fields
        public string UserId { get => userId; set => userId = value; }
        public DateTime Date { get => date; set => date = value; }
        public TimeSpan CheckIn { get => checkIn; set => checkIn = value; }
        public TimeSpan CheckOut { get => checkOut; set => checkOut = value; }
        public TimeSpan? RealCheckIn { get => realCheckIn; set => realCheckIn = value; }
        public TimeSpan? RealCheckOut { get => realCheckOut; set => realCheckOut = value; }
        public string Status { get => status; set => status = value; }
    }
}
