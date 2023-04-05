using System;
namespace euler_characteristic_edge
{
    class Program
    {
        static void Main(string[] args)
        {
            // V - E + F = 2
            //        -E = -V - F + 2
            //         E = V + F - 2
            Console.WriteLine("Please enter the vertex.");
            int vertex = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the face.");
            int face = int.Parse(Console.ReadLine());
            int edge;
            edge = vertex + face - 2;
            Console.WriteLine(">>> " + edge + "edges");
        }
    }
}