using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace GraphFun.Graph
{
    public class BellmanFordSearch : ISearchAlgorithm
    {
        public List<Vertex> Search(Vertex start, Vertex end)
        {
            throw new System.NotImplementedException();
        }

        // O(|V| * |E|) => O(n^2)
        public void PrintShortestPaths(WeightedDirectedGraph graph, Vertex source)
        {
            //Implement me
        }
    }
}