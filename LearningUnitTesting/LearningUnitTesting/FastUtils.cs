using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningUnitTesting
{
    public class FastUtils
    {
        private double valueA;
        private double valueB;

        public FastUtils(double a, double b)
        {
            valueA = a;
            valueB = b;
        }

        public double Multiply()
        {
            return valueA * valueB;
        }
    }
}
