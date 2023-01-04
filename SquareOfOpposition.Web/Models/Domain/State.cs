﻿namespace SquareOfOpposition.Web.Models.Domain
{
    public class State
    {
        public int Id { get; set; }
        public int SquareId { get; set; }
        public Square Square { get; set; }
        public int StateTypeId { get; set; }

        public virtual ICollection<StateTransition> InTransitions { get; set; }
        public virtual ICollection<StateTransition> OutTransitions { get; set; }

        public State()
        {
            Square = new Square();
            InTransitions = new HashSet<StateTransition>();
            OutTransitions = new HashSet<StateTransition>();
        }
    }
}
