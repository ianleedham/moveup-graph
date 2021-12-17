using System.Diagnostics;
using System;
using System.Collections.Generic;

namespace moveup_graph
{
    public class Graph
    {
        public Dictionary<int, string> numbersToLetters;
        private List<int>[] adjList;

        public Graph(int nodeCount)
        {
            adjList = new List<int>[nodeCount];
            for (int index = 0; index < nodeCount; index++){
                adjList[index] = new List<int>();
            }

            numbersToLetters = new Dictionary<int, string>();
            numbersToLetters.Add(0, "A");
            numbersToLetters.Add(1, "B");
            numbersToLetters.Add(2, "C");
            numbersToLetters.Add(3, "D");
            numbersToLetters.Add(4, "E");
            numbersToLetters.Add(5, "F");
            numbersToLetters.Add(6, "G");
            numbersToLetters.Add(7, "H");
        }

        public Graph AddVertex(int nodeOne, int nodeTwo){
            adjList[nodeOne].Add(nodeTwo);
            adjList[nodeTwo].Add(nodeOne); // needed?
            Console.WriteLine($"Adding vertex {numbersToLetters[nodeOne]}-{numbersToLetters[nodeTwo]}");
            return this;
        }

        public void FindShortestPath(int startNode, int endNode)
        {
            var previous = new Dictionary<int, int>();
            var visited = new List<int>();
            var queue = new Queue<int>();

            queue.Enqueue(startNode);
            visited.Add(startNode);

            while(queue.Count > 0){
                var currentNode = queue.Dequeue();
                Console.WriteLine($"visiting {numbersToLetters[currentNode]}");

                // check if you reached the destination
                if(currentNode == endNode){
                    break;
                }

                // queue all adjacent nodes which havn't been visited
                foreach(var neighbour in adjList[currentNode]){

                    // Console.WriteLine($"checking if {numbersToLetters[neighbour]} has been visited");
                    if(!visited.Contains(neighbour))
                    {
                        previous.Add(neighbour, currentNode);
                        if(neighbour != endNode)
                            visited.Add(neighbour);
                        Console.WriteLine($"enqueing {numbersToLetters[neighbour]} from {numbersToLetters[currentNode]}");
                        queue.Enqueue(neighbour);
                    }
                }
            }

            Console.WriteLine($"-------------------------------");
            Console.WriteLine($"The shortest path is:");
            int printedStep = endNode;
            bool cont = true;
            while(cont){
                Console.WriteLine($"{numbersToLetters[printedStep]}");
                cont = previous.TryGetValue(printedStep, out printedStep);
            }
            
        }
    }
}