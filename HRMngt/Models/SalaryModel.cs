using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMngt.Models
{
    public class SalaryModel
    {
        // Fields
        private string userId;
        private string userName;
        private string contract_type;
        private string position;
        private int month;
        private int year;
        private int workday;
        private int realWorkday;
        private int welfare;
        private int thumbTotal;
        private int ticketTotal;
        private double tax;
        private double totalSalary;
        private string res;
        private string status;

        // Encapsulate fields
        public string UserId { get => userId; set => userId = value; }
        public int Month { get => month; set => month = value; }
        public int Year { get => year; set => year = value; }
        public int Workday { get => workday; set => workday = value; }
        public int Welfare { get => welfare; set => welfare = value; }
        public int ThumbTotal { get => thumbTotal; set => thumbTotal = value; }
        public int TicketTotal { get => ticketTotal; set => ticketTotal = value; }
        public double Tax { get => tax; set => tax = value; }
        public double TotalSalary { get => totalSalary; set => totalSalary = value; }
        public string Res { get => res; set => res = value; }
        public string Status { get => status; set => status = value; }
        public int RealWorkday { get => realWorkday; set => realWorkday = value; }
        public string UserName { get => userName; set => userName = value; }
        public string Contract_type { get => contract_type; set => contract_type = value; }
        public string Position { get => position; set => position = value; }
    }
}
