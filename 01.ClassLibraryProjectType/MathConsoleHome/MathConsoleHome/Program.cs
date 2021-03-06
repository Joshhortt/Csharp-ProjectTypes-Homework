// 01 - HOMEWORK - Class Library Project Type
// Build a .NET Standard class Library and a Console Application.
// Put one or some calculation methods in it and call it from the console. Try different methods.

using System;
using StandardLibrary; // Importing StandardLibrary

namespace MathConsoleHome
{
   public class Program
    {
        static void Main(string[] args)
        {
            // Declare class from StandardLibrary.dll
            MathLesson math = new MathLesson();

            // Declare variables and use methods from StandardLibrary
            float substract = math.Substract(15, 2);
            float multiply = math.Multiply(25, 2);
            float devide = math.Devide(5, 2);
            float power = math.Power(10);

            Console.WriteLine("This Application uses functions from the StandardLibrary.dll to do simple calculations");

            // Print results on screen
            Console.WriteLine(substract);
            Console.WriteLine(multiply);
            Console.WriteLine(devide);
            Console.WriteLine(power);

            Console.ReadLine();
        }
    }
}
#region Second Example:
/*
using System;
using StandardLibrary;

namespace MathConsoleHome
{
	public class Program
	{
		static void Main(string[] args)
		{
            Console.WriteLine("Hello User!");

            // Read the first number   
            Console.Write("Enter a Number: ");
            var read1 = Console.ReadLine();
            // Convert a string to an int  
            int numb1 = Convert.ToInt32(read1);
            // Read the second number  
            Console.Write("Enter another Number: ");
            var read2 = Console.ReadLine();
            // Convert string to int  
            int numb2 = Convert.ToInt32(read2);
            // Read operation type - operator  
            Console.Write("Enter Operator: '+' for add, '-' for subtract, '*' for multiply,  '/' for devide) ");
            var op = Console.ReadLine();

            // Create a class library object and call the method CalculateTwoNumbers
            MathLesson math = new MathLesson();
            double result = math.CalculateTwoNumbers(numb1, numb2, op);

            Console.WriteLine("Result: {0}", result);

            Console.WriteLine("Press any key to exit Console....");
            Console.ReadKey(true);
        }
	}
}
*/
#endregion