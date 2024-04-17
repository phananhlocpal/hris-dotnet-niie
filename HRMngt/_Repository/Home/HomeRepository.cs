using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMngt._Repository.Home
{
    public class HomeRepository : IHomeRepository
    {
        private string connectionString = @"Data Source=localhost;Initial Catalog=HR;Integrated Security=True;";

        public HomeRepository()
        {

        }
    }
}
