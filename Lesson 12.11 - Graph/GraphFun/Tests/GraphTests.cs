using System.Diagnostics;
using GraphFun.Graph;
using Xunit;

namespace GraphFun.Tests
{
    public class GraphTests
    {
        [Fact]
        public void GraphTest()
        {
            var graph = new WeightedDirectedGraph();
            var la = new Vertex("Los Angeles");
            var sf = new Vertex("San Francisco");
            var lv = new Vertex("Las Vegas");
            var se = new Vertex("Seattle");
            var po = new Vertex("Portland");

            graph.AddPair(la, sf, 3);
            graph.AddPair(la, lv, 3);

            graph.AddPair(lv, sf, 3);

            graph.AddPair(sf, se, 4);
            graph.AddPair(sf, po, 2);
            graph.AddPair(sf, lv, 3);

            graph.AddPair(se, po, 3);

            graph.AddPair(po, sf, 4);
            graph.AddPair(po, la, 6);

            // Check to see that all neighbors are properly set up
            foreach (var vertex in graph.Vertices)
            {
                Debug.WriteLine(vertex.ToString());
            }

            int i = 0;

        }

        [Fact]
        public void BellmanTest()
        {
            var graph = new WeightedDirectedGraph();
            var s = new Vertex("S");
            var a = new Vertex("A");
            var b = new Vertex("B");
            var c = new Vertex("C");
            var d = new Vertex("D");
            var e = new Vertex("E");

            graph.AddPair(s, a, 4);
            graph.AddPair(b, a, 3);
            graph.AddPair(a, c, 6);
            graph.AddPair(d, a, 10);
            graph.AddPair(s, e, -5);

            graph.AddPair(e, d, 8);

            graph.AddPair(a, c, 6);

            graph.AddPair(e, d, 8);

            graph.AddPair(d, a, 10);
            graph.AddPair(d, c, 3);

            graph.AddPair(c, b, -2);
            graph.AddPair(b, a, 3);



            foreach (var vertex in graph.Vertices)
            {
                Debug.WriteLine(vertex.ToString());
            }

            var bellman = new BellmanFordSearch();
            bellman.PrintShortestPaths(graph, s);
        }

        [Fact]
        public void DijkstraTest()
        {
            var graph = new WeightedDirectedGraph();
            var s = new Vertex("S");
            var a = new Vertex("A");
            var b = new Vertex("B");
            var c = new Vertex("C");
            var d = new Vertex("D");
            var e = new Vertex("E");

            graph.AddPair(s, a, 4);
            graph.AddPair(s, e, 2);

            graph.AddPair(a, c, 6);
            graph.AddPair(a, b, 5);
            graph.AddPair(a, d, 3);

            graph.AddPair(e, d, 1);

            graph.AddPair(d, a, 1);
            graph.AddPair(d, c, 3);

            graph.AddPair(c, b, 1);
            graph.AddPair(b, a, 3);



            foreach (var vertex in graph.Vertices)
            {
                Debug.WriteLine(vertex.ToString());
            }

            var dijkstra = new DijkstraSearch();
            dijkstra.PrintShortestPaths(graph, s);
        }
    }
}
