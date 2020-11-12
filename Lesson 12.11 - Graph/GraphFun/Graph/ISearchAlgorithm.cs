using System.Collections.Generic;

namespace GraphFun.Graph
{
    public interface ISearchAlgorithm
    {
        List<Vertex> Search(Vertex start, Vertex end);

        void PrintShortestPaths(WeightedDirectedGraph graph, Vertex source);
    }
}