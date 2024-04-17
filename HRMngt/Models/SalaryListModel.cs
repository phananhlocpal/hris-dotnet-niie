using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMngt.Models
{
    public class SalaryListModel
    {
        public string UserId { get; set; }
        public string Name { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public string ContractType { get; set; }
        public string Position { get; set; }
        public string SalaryStatus { get; set; }
    }
}
