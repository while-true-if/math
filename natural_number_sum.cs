using System;
namespace natural_number_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            // (start + end) * quantity / 2
            Console.WriteLine("(start + end) * quantity / 2 = sum");
            Console.WriteLine("Please write the start.");
            int start = int.Parse(Console.ReadLine());
            Console.WriteLine("Please write the end.");
            int end = int.Parse(Console.ReadLine());
            Console.WriteLine("Please write the quantity.");
            int quantity = int.Parse(Console.ReadLine());
            int sum;
            sum = (start + end) * quantity / 2;
            Console.WriteLine(">>> " + sum);
        }
    }
}