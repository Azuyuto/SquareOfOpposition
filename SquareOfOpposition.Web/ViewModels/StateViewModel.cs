using SquareOfOpposition.Common.Enum;

namespace SquareOfOpposition.Web.ViewModels
{
    public class StateViewModel
    {
        public int Id { get; set; }
        public int SquareId { get; set; }
        public StateTypeEnum StateType { get; set; }

        public List<int> DestinationStateIds { get; set; }

        public StateViewModel()
        {
            DestinationStateIds = new List<int>();
        }
    }
}
