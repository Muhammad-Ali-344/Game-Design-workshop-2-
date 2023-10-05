using System;

public class Calculator
{
	public static void main Class1()

	{
        while (true)
        {

            Console.WriteLine("***************************");
            Console.WriteLine("Enter 1 for Add");
            Console.WriteLine("Enter 2 for Subtract");
            Console.WriteLine("Enter 3 for Multiply");
            Console.WriteLine("Enter 4 for Divide");
            Console.WriteLine("***************************");
            Console.WriteLine("Enter your choice (1/2/3/4): ");


            int choice = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            if (choice == 1)
            {
                Add(num1, num2);
            }
            else if (choice == 2)
            {
                Subtract(num1, num2);
            }
            else if (choice == 3)
            {
                Multiply(num1, num2);
            }
            else if (choice == 4)
            {
                if (num2 == 0)
                {
                    Console.WriteLine("Error: Division by zero");
                }
                else
                {
                    Divide(num1, num2);
                }

            }
            else
            {
                Console.WriteLine("Invalid choice. Please select 1, 2, 3, or 4");
            }
        }
    }
    public static void Add(double num1, double num2)
    {
        double result = num1 + num2;
        Console.WriteLine("***************************");
        Console.WriteLine("Result: " + result);
    }

    public static void Subtract(double num1, double num2)
    {
        double result = num1 - num2;
        Console.WriteLine("***************************");
        Console.WriteLine("Result: " + result);
    }

    public static void Multiply(double num1, double num2)
    {
        double result = num1 * num2;
        Console.WriteLine("***************************");
        Console.WriteLine("Result: " + result);
    }

    public static void Divide(double num1, double num2)
    {
        double result = num1 / num2;
        Console.WriteLine("***************************");
        Console.WriteLine("Result: " + result);
    }


}

