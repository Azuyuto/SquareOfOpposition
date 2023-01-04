using AutoMapper;
using Microsoft.AspNetCore.Mvc.Rendering;
using SquareOfOpposition.Common.Enum;
using SquareOfOpposition.Web.Interfaces;
using SquareOfOpposition.Web.Models.Domain;

namespace SquareOfOpposition.Web.ViewModels
{
    public class SquareViewModel
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public string? SentenceA { get; set; }
        public string? SentenceE { get; set; }
        public string? SentenceI { get; set; }
        public string? SentenceO { get; set; }

        public List<SelectListItem> States { get; set; }

        public StateViewModel StateAI { get; set; }
        public StateViewModel StateEO { get; set; }
        public StateViewModel StateIO { get; set; }

        public SquareViewModel()
        {
            States = new List<SelectListItem>();
            StateAI = new StateViewModel() { 
                StateType = StateTypeEnum.AI
            };
            StateEO = new StateViewModel()
            {
                StateType = StateTypeEnum.EO
            };
            StateIO = new StateViewModel() {
                StateType = StateTypeEnum.IO
            };
        }

        public void Initialize(IMapper _mapper, IStateRepository _stateRepository)
        {
            States = _stateRepository.GetAll().Select(a => _mapper.Map<StateViewModel>(a)).Select(a => new SelectListItem() { 
                Text = String.Format("#{0} {1} - {2}",a.Square.Id, a.Square.Name, a.StateType),
                Value = a.Id.ToString()
            }).ToList();
        }

        public Square ToModel(IMapper _mapper)
        {
            var entity = _mapper.Map<Square>(this);
            entity.States = new List<State>() {
                _mapper.Map<State>(StateAI),
                _mapper.Map<State>(StateEO),
                _mapper.Map<State>(StateIO),
            };

            return entity;
        }
    }
}
