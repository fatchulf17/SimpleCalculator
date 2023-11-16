using System;

namespace SimpleCalculator
{
    public class Calculator
    {
        public double Add(double num1, double num2)
        {
            return num1 + num2;
        }

        public double Subtract(double num1, double num2)
        {
            return num1 - num2;
        }

        public double Multiply(double num1, double num2)
        {
            return num1 * num2;
        }

        public double Divide(double num1, double num2)
        {
            if (num2 == 0.0)
            {
                throw new DivideByZeroException("ERROR: Zero Division Error");
            }

            return num1 / num2;
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Operator ( + - * / ): ");
            string op = Console.ReadLine();

            Console.Write("Enter another number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Calculator calculator = new Calculator();

            try
            {
                double answer = PerformCalculation(calculator, num1, op, num2);
                Console.WriteLine($"Answer: {answer}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }

        public static double PerformCalculation(Calculator calculator, double num1, string op, double num2)
        {
            switch (op)
            {
                case "+":
                    return calculator.Add(num1, num2);

                case "-":
                    return calculator.Subtract(num1, num2);

                case "*":
                    return calculator.Multiply(num1, num2);

                case "/":
                    return calculator.Divide(num1, num2);

                default:
                    throw new InvalidOperationException("ERROR: Invalid Operator");
            }
        }
    }
}
