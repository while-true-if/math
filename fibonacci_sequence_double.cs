using System;
namespace fibonacci_sequence_double
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            double n = 1;
            double m = 1;
            Console.WriteLine(">>> " +  n);
            Console.WriteLine(">>> " +  m);
            while (i <= 736)
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