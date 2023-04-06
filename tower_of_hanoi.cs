// h = 2^n - 1
using System;
namespace tower_of_hanoi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many levels does the Tower of Hanoi have?");
            double n = double.Parse(Console.ReadLine());
            double h;
            h = Math.Pow(2, n) - 1;
            Console.WriteLine(">>> " + h + "times");
            Console.WriteLine("How many seconds does it take to move it per one attempt?");
            double seconds = double.Parse(Console.ReadLine());
            Console.WriteLine(">>> " + seconds * h + "seconds");
            Console.WriteLine(">>> " + seconds * h / 60 + "minutes");
            Console.WriteLine(">>> " + seconds * h / 3600 + "hours");
            Console.WriteLine(">>> " + seconds * h / 86400 + "days");
            Console.WriteLine(">>> " + seconds * h / 604800 + "weeks");
            Console.WriteLine(">>> " + seconds * h / 2592000 + "months(1month = 30days)");
            Console.WriteLine(">>> " + seconds * h / 31536000 + "years(1year = 365days)");
        }
    }
}