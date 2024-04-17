using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HRMngt.Models
{
    public class RecruitModel
    {
        private string id;
        private string name;
        private string email;
        private string phone;
        private string departmentName;
        private string managerName;
        private string address;
        private string sex;
        private DateTime birthday;
        private string position;
        private string roles;
        private string note;
        private string status;
        private string contract_type;

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Email { get => email; set => email = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Address { get => address; set => address = value; }
        public string Sex { get => sex; set => sex = value; }
        public DateTime Birthday { get => birthday; set => birthday = value; }
        public string Position { get => position; set => position = value; }
        public string Roles { get => roles; set => roles = value; }
        public string Note { get => note; set => note = value; }
        public string Status { get => status; set => status = value; }
        public string Contract_type { get => contract_type; set => contract_type = value; }
        public string DepartmentName { get => departmentName; set => departmentName = value; }
        public string ManagerName { get => managerName; set => managerName = value; }
    }
}
