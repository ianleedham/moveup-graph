using System;
using System.Collections.Generic;

namespace moveup_graph
{
    public class Graph
    {
        private List<int>[] adjList;

        public Graph(int nodeCount)
        {
            adjList = new List<int>[nodeCount];
            for (int index = 0; index < nodeCount; index++){
                adjList[index] = new List<int>();
            }
        }

        public Graph AddVertex(int nodeOne, int nodeTwo){
            adjList[nodeOne].Add(nodeTwo);
            adjList[nodeTwo].Add(nodeOne); // needed?
            Console.WriteLine($"Adding vertex {nodeOne}-{nodeTwo}");
            return this;
        }
    }
}