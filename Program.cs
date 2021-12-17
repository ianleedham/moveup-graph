using System;

namespace moveup_graph
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Welcome to moveups graph example by Ian Leedham!");

            var graph = new Graph(8);
            graph.AddVertex(0, 1) // A - B
            .AddVertex(0, 3) // A - D
            .AddVertex(0, 7) // A - H
            .AddVertex(1, 2) // B - C
            .AddVertex(1, 3) // B - D
            .AddVertex(2, 3) // C - D
            .AddVertex(2, 5) // C - F
            .AddVertex(3, 4) // D - E
            .AddVertex(4, 5) // E - F
            .AddVertex(4, 7) // E - H
            .AddVertex(5, 6) // F - G
            .AddVertex(6, 7); // G - H
            Console.WriteLine("-----------Graph built-----------");


            graph.FindShortestPath(0, 7);
        }
    }
}
