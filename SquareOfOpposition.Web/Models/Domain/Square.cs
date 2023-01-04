namespace SquareOfOpposition.Web.Models.Domain
{
    public class Square
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public string? SentanceA { get; set; }
        public string? SentanceE { get; set; }
        public string? SentanceI { get; set; }
        public string? SenranceO { get; set; }

        public virtual ICollection<State> States { get; set; }

        public Square()
        {
            States = new HashSet<State>();
        }
    }
}
