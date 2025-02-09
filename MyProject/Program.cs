using System;

namespace MyProject
{
    class Program
    {
        static void Main(string[] args)
        {
            int a , b;
            Console.WriteLine("Enter the first number");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The sum of the two numbers is: " + (a + b));
            Console.ReadKey();
        }
    }
}