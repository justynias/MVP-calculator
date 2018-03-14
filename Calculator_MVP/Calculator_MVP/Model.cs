using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_MVP
{
    public class Model
    {
        public Model()
        { }
        Operation operation = new Operation();
        internal double GetResult(double value1, string operator_)
        {
            return operation.PerformOperation(value1,operator_);
        }

    }
}
