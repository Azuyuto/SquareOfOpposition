using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SquareOfOpposition.Web.Models.Domain
{
    public class StateTransition
    {
        public int Id { get; set; }
        public int PickupStateId { get; set; }
        public virtual State PickupState { get; set; }
        public int DestinationStateId { get; set; }
        public virtual State DestinationState { get; set; }
        public string? Name { get; set; }

        public StateTransition()
        {
            PickupState = new State();
            DestinationState = new State();
        }
    }
}
