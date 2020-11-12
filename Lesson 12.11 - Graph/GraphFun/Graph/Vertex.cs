using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GraphFun.Graph
{
    public class Vertex
    {
        public string Name { get; }

        public int Cost { get; set; } = Int32.MaxValue;
        public bool IsVisited { get; set; }

        public List<Edge> Edges { get; }
        public List<Vertex> Neighbors { get; }

        public Vertex(string name)
        {
            Name = name;
            Edges = new List<Edge>();
            Neighbors = new List<Vertex>();
        }

        public void AddNeighbor(Vertex vertex)
        {

        }

        public void AddEdge(Edge edge)
        {

        }

        public override string ToString()
        {
            return $"{(string.Join(Environment.NewLine, Edges.Select(n => n.ToString())))}";
        }
    }
}