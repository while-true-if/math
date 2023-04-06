using System;
namespace fibonacci_sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int n = 1;
            int m = 1;
            Console.WriteLine(">>> " +  n);
            Console.WriteLine(">>> " +  m);
            while (i <= 21)
            {
                i ++ ;
                n += m;
                Console.WriteLine(">>> " + n);
                m += n;
                Console.WriteLine(">>> " + m);
            }
        }
    }
}