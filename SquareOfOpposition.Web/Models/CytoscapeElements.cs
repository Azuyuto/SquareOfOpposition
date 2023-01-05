namespace SquareOfOpposition.Web.Models
{
    public class CytoscapeElements
    {
        public List<Node> nodes { get; set; }
        public List<Edge> edges { get; set; }

        public CytoscapeElements()
        {
            nodes = new List<Node>();
            edges = new List<Edge>();
        }
    }

    public class Node
    {
        public CytoscapeData data { get; set; }

        public Node()
        {
            data = new CytoscapeData();
        }
    }

    public class Edge
    {
        public CytoscapeData data { get; set; }

        public Edge()
        {
            data = new CytoscapeData();
        }
    }

    public class CytoscapeData
    {
        public string? id { get; set; }
        public string? name { get; set; }
        public string? source { get; set; }
        public string? target { get; set; }
        public string? color { get; set; }
    }
}
