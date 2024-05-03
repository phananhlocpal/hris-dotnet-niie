using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMngt.Model
{
    public interface IThumbTicketRepository
    {
        void Add(ThumbTicketModel thumbTicketModel);
        void Update(ThumbTicketModel thumbTicketModel);
        void Delete(string id);
        IEnumerable<ThumbTicketModel> GetAll();
        IEnumerable<ThumbTicketModel> GetByMonth(int month);
        IEnumerable<ThumbTicketModel> GetByType(string type);
        ThumbTicketModel GetById(string id);
        IEnumerable<ThumbTicketModel> GetByUserId(string id);
    }
}
