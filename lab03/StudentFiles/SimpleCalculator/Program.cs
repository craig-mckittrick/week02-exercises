using System;

namespace SimpleCalculator
{
    class Program
    {
        private const string number1Prompt = "Please enter the first number: ";
        private const string number2Prompt = "Please enter the second number: ";

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the simple calculator!");
            var option = PrintMenu();
            if (option == 1)
            {
                Add();
            }
            else if (option == 2)
            {
                Subtract();
            }
            else if (option == 3)
            {
                Multiply();
            }
            else if (option == 4)
            {
                var n1 = GetValueFromUser("Please enter the dividend: ");
                var n2 = GetValueFromUser("Please enter the divisor: ");
                if (n2 == 0)
                {
                    n2 = GetValueFromUser("Please enter a divisor that is not '0'");
                }
                var quotient = Divide(n1, n2);
                Console.WriteLine($"The result of {n1} / {n2} is {quotient}");
            }
            else if (option == 5)
            {
                //square  
                var n1 = GetValueFromUser("Please enter the number to square");
                double squareResult = Math.Pow(n1, 2);
                Console.WriteLine($"{n1} * {n1} ({n1}^2) = {squareResult}");
            }
            else if (option == 6)
            {
                //absolute value  
                var subtractResult = Subtract();
                var absValue = Math.Abs(subtractResult);
                Console.WriteLine($"The absolute value of {subtractResult} is: {absValue}");
            }
            else if (option == 7)
            {
                //Round  
                var n1 = GetValueFromUser("Please enter the number to round");
                var roundResult = Math.Round(n1);
                Console.WriteLine($"Rounding {n1} produces the value {roundResult}.");
            }
            else
            {
                Console.WriteLine("You have entered an invalid choice.");
            }
            /*
                        //add
                        var addResult = Add(number1, number2);
                        Console.WriteLine($"{number1} + {number2} = {addResult}");

                        //subtract
                        var subtractResult = Subtract(number1, number2);
                        Console.WriteLine($"{number1} - {number2} = {subtractResult}");

                        //multiply
                        var multiplyResult = Multiply(number1, number2);
                        Console.WriteLine($"{number1} * {number2} = {multiplyResult}");

                        //divide
                        var divideResult = Divide(number1, number2);
                        Console.WriteLine($"{number1} / {number2} = {divideResult}");

                        //square
                        var squareResult1 = Math.Pow(number1, 2);
                        Console.WriteLine($"{number1} * {number1} ({number1}^2) = {squareResult1}");

                        //absolute value
                        var absValue = Math.Abs(subtractResult);
                        Console.WriteLine($"The absolute value of {subtractResult} = {absValue}");

                        //Round
                        var roundResult = Math.Round(divideResult);
                        Console.WriteLine($"Rounding {divideResult} produces the value {roundResult}");
            */
            Console.WriteLine("Thank you for calculating with me today!");
        }

        private static int PrintMenu()
        {
            Console.WriteLine(new String('*', 80));
            Console.WriteLine($"{"* What would you like to do today?",-79}*");
            Console.WriteLine($"{"* 1) Add",-79}*");
            Console.WriteLine($"{"* 2) Subtract",-79}*");
            Console.WriteLine($"{"* 3) Multiply",-79}*");
            Console.WriteLine($"{"* 4) Divide",-79}*");
            Console.WriteLine($"{"* 5) Square",-79}*");
            Console.WriteLine($"{"* 6) Absolute Value",-79}*");
            Console.WriteLine($"{"* 7) Round",-79}*");
            Console.WriteLine(new String('*', 80));
            return Convert.ToInt32(Console.ReadLine());
        }

        private static double GetValueFromUser(string message)
        {
            //Console.WriteLine("Please enter the first number:");
            Console.WriteLine(message);
            return Convert.ToDouble(Console.ReadLine());
        }
        static double Add()
        {
            var n1 = GetValueFromUser(number1Prompt);
            var n2 = GetValueFromUser(number2Prompt);
            var addResult = n1 + n2;
            Console.WriteLine($"{n1} + {n2} = {addResult}");
            return addResult;
        }

        private static double Subtract()
        {
            var n1 = GetValueFromUser(number1Prompt);
            var n2 = GetValueFromUser(number2Prompt);
            var subtractResult = n1 - n2;
            Console.WriteLine($"{n1} - {n2} = {subtractResult}");
            return subtractResult;
        }

        private static double Multiply()
        {
            var n1 = GetValueFromUser(number1Prompt);
            var n2 = GetValueFromUser(number2Prompt);
            var multiplyResult = n1 * n2;
            Console.WriteLine($"{n1} * {n2} = {multiplyResult}");
            return multiplyResult;
        }

        static double Divide(double n1, double n2)
        {
            return n1 / n2;
        }
    }
}
