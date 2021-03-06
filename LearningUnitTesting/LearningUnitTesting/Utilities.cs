﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningUnitTesting
{
    public static class Utilities
    {
        public static double Multiply(double a, double b)
        {
            // Write code here to satisfy the tests
            return a * b;
        }

        public static double Divide(double a, double b)
        {
            // divide a / b, but make sure you arent' dividing by zero
            if (b != 0)
                return a / b;

            else
                return double.NaN;
        }

        public static double StringToDouble(string val)
        {
            double result;
            if (!double.TryParse(val, out result))
                return double.NaN;
            return result;
        }
    }
}
