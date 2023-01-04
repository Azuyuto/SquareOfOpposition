using SquareOfOpposition.Common.Enum;
using SquareOfOpposition.Web.Models.Domain;

namespace SquareOfOpposition.Web.ViewModels
{
    public class StateViewModel
    {
        public int Id { get; set; }
        public int SquareId { get; set; }
        public Square Square { get; set; }
        public StateTypeEnum StateType { get; set; }

        public List<StateTransition> StateTransition { get; set; }

        public StateViewModel()
        {
            Square = new Square();
            StateTransition = new List<StateTransition>();
        }
    }
}
