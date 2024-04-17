using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMngt._Repository.Support
{
    public interface ISupportRepository
    {
        void Send(string message, string email);
        void Back();
    }
}
