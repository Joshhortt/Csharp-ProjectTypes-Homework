
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StandardLibrary
{
    public class MathLesson
    {
        // This is the Standard Library with Methdos and parameters within.
        public float Substract(float a, float b)  
        {
            return a - b;
        }

        public float Multiply(float a, float b)
        {
            return a * b;
        }

        public float Devide(float a, float b)
        {
            return a / b;
        }

        public float Power(float a)
        {
            return a * a;
        }
    }
}

#region Second Example:
/*
using System;
using System.Collections.Generic;
using System.Text;
using StandardLibrary;

namespace StandardLibrary
{
	public class MathLesson
	{
        public MathLesson() { }

        public double CalculateTwoNumbers(double numb1, double numb2, string op)
        {
            double result = 0;
            switch (op)
            {
                case "+":
                    result = numb1 + numb2;
                    break;
                case "-":
                    result = numb1 - numb2;
                    break;
                case "*":
                    result = numb1 * numb2;
                    break;
                case "/":
                    result = (double)numb1 / numb2;
                    break;
                default:
                    break;
            }
            return result;
        }
    }
}
*/
#endregion