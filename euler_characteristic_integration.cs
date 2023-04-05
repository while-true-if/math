using System;
namespace euler_characteristic_edge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please select the following number for the parts that you do not understand.");
            Console.WriteLine("0:vertex, 1:edge, 2:face");
            int choice = int.Parse(Console.ReadLine());
            if (choice == 0)
            {
                // V - E + F = 2
                //         V = E - F + 2
                Console.WriteLine("Please enter the edge.");
                int edge = int.Parse(Console.ReadLine());
                Console.WriteLine("Please enter the face.");
                int face = int.Parse(Console.ReadLine());
                int vertex;
                vertex = edge - face + 2;
                Console.WriteLine(">>> " + vertex + "vertexes");
            }
            else if (choice == 1)
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
            else
            {
                // V - E + F = 2
                //         F = -V + E + 2
                Console.WriteLine("Please enter the vertex.");
                int vertex = int.Parse(Console.ReadLine());
                Console.WriteLine("Please enter the edge.");
                int edge = int.Parse(Console.ReadLine());
                int face;
                face = -vertex + edge + 2;
                Console.WriteLine(">>> " + face + "faces");
            }
        }
    }
}