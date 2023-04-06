// c^2 = a^2 + b^2
using System;
namespace pythagorean_theorem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("c^2 = a^2 + b^2");
            Console.WriteLine("Please select from the following options what you would like to calculate using the Pythagorean theorem.");
            Console.WriteLine("0:a, 1:b, 2:c");
            int choice = int.Parse(Console.ReadLine());
            // h = Math.Pow(2, n) - 1;
            if (choice == 0)
            {
                Console.WriteLine("Please write the b");
                double b = double.Parse(Console.ReadLine());
                Console.WriteLine("Please write the c");
                double c = double.Parse(Console.ReadLine());
                double a = Math.Sqrt(Math.Pow(c, 2) - Math.Pow(b, 2));
                Console.WriteLine(">>> " + a);
            }
            else if (choice == 1)
            {
                Console.WriteLine("Please write the a");
                double a = double.Parse(Console.ReadLine());
                Console.WriteLine("Please write the c");
                double c = double.Parse(Console.ReadLine());
                double b = Math.Sqrt(Math.Pow(c, 2) - Math.Pow(a, 2));
                Console.WriteLine(">>> " + b);
            }
            else
            {
                Console.WriteLine("Please write the a");
                double a = double.Parse(Console.ReadLine());
                Console.WriteLine("Please write the b");
                double b = double.Parse(Console.ReadLine());
                double c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
                Console.WriteLine(">>> " + c);
            }
        }
    }
}