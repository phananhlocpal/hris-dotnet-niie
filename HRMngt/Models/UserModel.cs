using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Drawing;

namespace HRMngt.Models
{
    public class UserModel
    {
        //Fields
        private string id;
        private string name;
        private string email;
        private string phone;
        private string address;
        private DateTime birthday;
        private string sex;
        private string position;
        private int salary;
        private string username;
        private string password;
        private string managerID;
        private string departmentID;
        private string contract_type;
        private DateTime on_boarding;
        private DateTime? close_date;
        private string scan_contract;
        private string note;
        private string ava;
        private string status;
        private byte[] photo;
        private string roles;
        private string degree;

        // Encapsulate fields
        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Email { get => email; set => email = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Address { get => address; set => address = value; }
        public DateTime Birthday { get => birthday; set => birthday = value; }
        public string Sex { get => sex; set => sex = value; }
        public string Position { get => position; set => position = value; }
        public int Salary { get => salary; set => salary = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string ManagerID { get => managerID; set => managerID = value; }
        public string DepartmentID { get => departmentID; set => departmentID = value; }
        public string Contract_type { get => contract_type; set => contract_type = value; }
        public DateTime On_boarding { get => on_boarding; set => on_boarding = value; }
        public DateTime? Close_date { get => close_date; set => close_date = value; }
        public string Scan_contract { get => scan_contract; set => scan_contract = value; }
        public string Note { get => note; set => note = value; }
        public string Ava { get => ava; set => ava = value; }
        public string Status { get => status; set => status = value; }
        public byte[] Photo { get => photo; set => photo = value; }
        public string Roles { get => roles; set => roles = value; }
        public string Degree { get => degree; set => degree = value; }
    }
}
