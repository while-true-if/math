using System;
namespace euler_characteristic_vertex
{
    class Program
    {
        static void Main(string[] args)
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
    }
}