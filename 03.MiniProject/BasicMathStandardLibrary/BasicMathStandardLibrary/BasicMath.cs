// HOMEWORK - 03 - Mini-Project - Basic Bath (Unit Tests)
// Build a Class Library (.NET Core Standard) with a class that does the basic math operations.
// Create unit tests for all methods.
using System;
using System.Collections.Generic;
using System.Text;

namespace BasicMathStandardLibrary
{
    public class BasicMath
    {
        public double Add(double num1, double num2)
        {
            return num1 + num2;
        }
        public double Substract(double num1, double num2)
        {
            return num1 - num2;
        }
        public double Divide(double num1, double num2)
        {
            // return num1 / num2;
            double result = 0;

            if (num2 != 0)
            {
                result = num1 / num2;
            }
            return result;
        }
        public double Multiply(double num1, double num2)
        {
            // To trace error while testing, writing + operator instead of * operator.  
            return num1 * num2;
        }
    }
}
