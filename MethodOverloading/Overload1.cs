﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    internal class Overload1
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static double Add(double a, double b)
        {
            return (double)a + b;
        }

        public static string Add(int a, int b, bool dollars)
        {
            int result = a + b;
        if  (dollars == true && result == 1)
            {
                return ($"{result} dollar");
            }
        else if (dollars == true)
            {
                return ($"{result} dollars");
            }
        else
            {
                return ($"{result}");
            }
        }
    }
}