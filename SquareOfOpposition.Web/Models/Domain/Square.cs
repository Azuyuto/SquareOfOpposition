namespace SquareOfOpposition.Web.Models.Domain
{
    public class Square
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Color { get; set; }

        public string? SentenceA { get; set; }
        public string? SentenceE { get; set; }
        public string? SentenceI { get; set; }
        public string? SentenceO { get; set; }

        public virtual ICollection<State> States { get; set; }

        public Square()
        {
            States = new HashSet<State>();
        }
    }
}
