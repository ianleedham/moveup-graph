using System;

namespace moveup_graph
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Welcome to moveups graph example by Ian Leedham!");

            var graph = new Graph(8);
            graph.AddVertex(0, 1)
            .AddVertex(0, 3)
            .AddVertex(0, 7)
            .AddVertex(1, 2)
            .AddVertex(1, 3)
            .AddVertex(2, 3)
            .AddVertex(1, 5)
            .AddVertex(3, 4)
            .AddVertex(4, 5)
            .AddVertex(4, 7)
            .AddVertex(5, 6)
            .AddVertex(6, 7);
        }
    }
}
