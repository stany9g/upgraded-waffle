using System.Collections.Generic;

namespace GraphFun.Graph
{
    public class WeightedDirectedGraph
    {
        public List<Vertex> Vertices { get; }

        public WeightedDirectedGraph()
        {
            Vertices = new List<Vertex>();
        }

        public void AddPair(Vertex from, Vertex to, int weight)
        {

        }

        private void AddToList(Vertex vertex)
        {

        }

        private void AddNeighbors(Vertex from, Vertex to, int weight)
        {

        }


        public List<Vertex> ShortestPath<TSearchAlgorithm>(Vertex start, Vertex end) where TSearchAlgorithm : ISearchAlgorithm, new()
        {
            var algorithm = new TSearchAlgorithm();
            return algorithm.Search(start, end);
        }
    }
}