namespace SquareOfOpposition.Web.Models.Domain
{
    public class State
    {
        public int Id { get; set; }
        public int SquareId { get; set; }
        public Square Square { get; set; }
        public int StateTypeId { get; set; }

        public ICollection<State> States { get; set; }
        public ICollection<State> StateOf { get; set; }

        public State()
        {
            Square = new Square();
            States = new HashSet<State>();
            StateOf = new HashSet<State>();
        }
    }
}
