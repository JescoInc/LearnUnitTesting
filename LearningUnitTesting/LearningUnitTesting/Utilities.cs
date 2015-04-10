using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningUnitTesting
{
    public class Utilities
    {
        public static double Multiply(double a, double b)
        {
            // Write code here to satisfy the tests
            return a * b;
        }

        public static double Divide(double a, double b)
        {
            // divide a / b, but make sure you arent' dividing by zero
            return double.MinValue;
        }
    }
}
