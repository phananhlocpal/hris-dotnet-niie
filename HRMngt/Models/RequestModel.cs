using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMngt.Models
{
    public class RequestModel
    {
        private int id;
        private string type;
        private DateTime time;
        private string sender;
        private string senderName;
        private string approver;
        private string approverName;
        private int status;

        public int Id { get => id; set => id = value; }
        public string Type { get => type; set => type = value; }
        public DateTime Time { get => time; set => time = value; }
        public string Sender { get => sender; set => sender = value; }
        public string SenderName { get => senderName; set => senderName = value; }
        public string Approver { get => approver; set => approver = value; }
        public string ApproverName { get => approverName; set => approverName = value; }
        public int Status { get => status; set => status = value; }
    }
}
