using System;
namespace euler_characteristic_face
{
    class Program
    {
        static void Main(string[] args)
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