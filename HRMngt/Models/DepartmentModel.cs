using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMngt.Models
{
    public class DepartmentModel
    {
        //Fields
        private string id;
        private string name;
        private string phone;
        private string location;
        private string manager;

        // Encapsulate fields
        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Location { get => location; set => location = value; }
        public string Manager { get => manager; set => manager = value; }
    }
}
