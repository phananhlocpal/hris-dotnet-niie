using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace HRMngt.Views.Dialogs.Interface
{
    public interface ICheckinDialog
    {

        string label1 { get; set; }
        string label2 { get; set; }
        string label3 { get; set; }
        event EventHandler AddToCalculator;

        void Show();
    }
}
