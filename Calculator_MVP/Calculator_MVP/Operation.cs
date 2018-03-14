using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_MVP
{
    public class Operation
    {
        public double Value1 { get; set; }
        //public double Value2 { get; set; } 
        public double Result { get; set; }
        public string Operator { get; set; }

        public double PerformOperation(double value1,  string operator_)
        {
            Value1 = value1;
            Operator = operator_;
            switch (Operator)
            {
             
                case "+":
                    Result = Result + Value1;
                    break;
                case "-":
                    Result = Result - Value1;
                    break;
                case "*":
                    Result = Result * Value1;
                    break;
                case "/":
                    Result = Result / Value1;  //EXCEPTION!! 0!!
                    break;
                default:
                    Result = Value1;
                    break;
            }
            
            return Result;
        }

        
    }
}
