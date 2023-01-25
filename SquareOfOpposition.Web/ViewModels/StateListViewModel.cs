using AutoMapper;
using SquareOfOpposition.Web.Interfaces;

namespace SquareOfOpposition.Web.ViewModels
{
    public class StateListViewModel
    {
        public int ParentStateId { get; set; }
        public List<StateViewModel> List { get; set; }

        public StateListViewModel()
        {
            List = new List<StateViewModel>();
        }

        public void Initialize(IMapper _mapper, IStateRepository _stateRepository)
        {
            var p = ParentStateId != 0 ? (int?)ParentStateId : null;
            List = _stateRepository.GetMany(a => a.Square.ParentStateId == p, a => a.Square, a => a.OutTransitions)
                    .Select(a => _mapper.Map<StateViewModel>(a)).ToList();
        }
    }
}
