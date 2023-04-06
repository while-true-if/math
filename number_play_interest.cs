using System;
using System.Threading;
namespace number_play
{
    class Program
    {
        static void Main(string[] args)
        {
            double i = 0;
            double n = 10000;
            double m = 10000;
            Console.WriteLine("What percentage is the interest rate for one side?");
            double n_i = double.Parse(Console.ReadLine());
            Console.WriteLine("What percentage is the interest rate for the other side?");
            double m_i = double.Parse(Console.ReadLine());
            double n_i_r = 1 + (n_i / 100);
            double m_i_r = 1 + (m_i / 100);
            while (true)
            {
                i++;
                n *= n_i_r;
                m *= m_i_r;
                double difference = m - n;
                Console.WriteLine(i + "年目  " + n.ToString("F0") + " dollars  " + m.ToString("F0") + " dollars  " + "difference " + difference.ToString("F0") + "dollars");
                Thread.Sleep(100);
            }
        }
    }
}