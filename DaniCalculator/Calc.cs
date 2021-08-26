using System;
using System.Collections.Generic;
using System.Text;

namespace DaniCalculator
{
    class Calc
    {
            public static decimal Add(decimal x, decimal y)
            {
                decimal num1 = x;
                decimal num2 = y;
                decimal result = num1 + num2;
                return result;
            }
            public static decimal Sub(decimal x, decimal y)
            {
                decimal num1 = x;
                decimal num2 = y;
                decimal result = num1 - num2;
                return result;
            }

            public static decimal Mult(decimal x, decimal y)
            {
                decimal num1 = x;
                decimal num2 = y;
                decimal result = num1 * num2;
                return result;
            }

            public static decimal Div(decimal x, decimal y)
            {
                decimal num1 = x;
                decimal num2 = y;
                decimal result = num1 % num2;
                return result;
            }

    }
}
