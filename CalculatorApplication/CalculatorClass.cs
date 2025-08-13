using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApplication
{
    namespace CalculatorApplication
    {
        public class CalculatorClass
        {     
         public delegate X Formula<X>(X arg1, X arg2);
         public delegate void Information<X>(X arg1);        
            public Formula<double> CalculateEvent;         
            public Information<string> info;       
            public double GetSum(double num1, double num2)
            {
                return num1 + num2;
            }
            public double GetDifference(double num1, double num2)
            {
                return num1 - num2;
            }       
            public double GetProduct(double num1, double num2)
            {
                return num1 * num2;
            }
            public double GetQuotient(double num1, double num2)
            {
                if (num2 == 0)
                    return double.NaN;
                return num1 / num2;
            }       
            public event Formula<double> Calculate
            {
                add
                {
                    CalculateEvent += value;
                    Console.WriteLine("Added the delegate");
                }
                remove
                {
                    CalculateEvent -= value;
                    Console.WriteLine("Removed the delegate");
                }
            }
        }
    }
}
