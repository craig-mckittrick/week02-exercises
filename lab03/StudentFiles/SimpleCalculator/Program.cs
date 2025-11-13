using System;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the simple calculator!");
            Console.WriteLine("Please enter the first number:");
            var number1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter the second number:");
            var number2 = Convert.ToDouble(Console.ReadLine());

            //add
            var addResult = Add(number1, number2);
            Console.WriteLine($"{number1} + {number2} = {addResult}");

            //subtract
            var subtractResult = Subtract(number1 , number2);
            Console.WriteLine($"{number1} - {number2} = {subtractResult}");

            //multiply
            var multiplyResult = Multiply(number1, number2);
            Console.WriteLine($"{number1} * {number2} = {multiplyResult}");

            //divide
            var divideResult = Divide(number1 , number2);
            Console.WriteLine($"{number1} / {number2} = {divideResult}");

            //square
            var squareResult1 = Math.Pow(number1,2);
            Console.WriteLine($"{number1} * {number1} ({number1}^2) = {squareResult1}");

            //absolute value
            var absValue = Math.Abs(subtractResult);
            Console.WriteLine($"The absolute value of {subtractResult} = {absValue}");

            //Round
            var roundResult = Math.Round(divideResult);
            Console.WriteLine($"Rounding {divideResult} produces the value {roundResult}");

            Console.WriteLine("Thank you for calculating with me today!");
        }

        static double Add(double n1, double n2)
        {
            return n1 + n2;
        }

        static double Subtract(double n1, double n2)
        {
            return n1 - n2;
        }

        static double Multiply(double n1, double n2)
        {
            return n1 * n2;
        }

        static double Divide(double n1, double n2)
        {
            return n1 / n2;
        }
    }
}
