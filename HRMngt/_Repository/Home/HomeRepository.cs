using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMngt._Repository.Home
{
    public class HomeRepository : BaseRepository, IHomeRepository
    {
        private string connectionString = BaseRepository.connectionString;

        public HomeRepository()
        {

        }
    }
}
