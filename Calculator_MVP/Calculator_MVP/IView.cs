using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_MVP
{
    public interface IView
    {
        event Func<object, EventArgs, double> ViewEvent;
        double Value1 { get; set; }
        //double Value2 { get; set; }
        double Result { get; set; }
        string Operator { get; set; }
    }
}
