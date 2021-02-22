using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPW212_UnitTestStarterCode
{
    public class SimpleMath
    {
        public double Add(double a, double b)
        {
            double sum = a + b;
            return sum;
        }

        public double Subtract(double a, double b)
        {
            double difference = a - b;
            return difference;
        }

        public double Multiply(double a, double b)
        {
            double product = a * b;
            return product;
        }

        public double Divide(double a, double b)
        {
            double quotient = a / b;
            if (b == 0)
            {
                throw new DivideByZeroException("Denominator cannot be zero!");
            }
            return quotient;
        }
    }
}
