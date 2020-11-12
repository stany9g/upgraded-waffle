namespace GraphFun.Graph
{
    public class Edge
    {
        public int Weight { get;  }
        public Vertex From { get; }
        public Vertex To { get; }

        public Edge(int weight, Vertex from, Vertex to)
        {
            Weight = weight;
            From = from;
            To = to;
        }

        public override string ToString()
        {
            return $"{From.Name} -- ({Weight}) --> {To.Name}";
        }
    }
}