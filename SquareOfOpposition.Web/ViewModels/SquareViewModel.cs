using AutoMapper;
using Microsoft.AspNetCore.Mvc.Rendering;
using SquareOfOpposition.Common.Enum;
using SquareOfOpposition.Web.Helpers;
using SquareOfOpposition.Web.Interfaces;
using SquareOfOpposition.Web.Models.Domain;
using System.ComponentModel;

namespace SquareOfOpposition.Web.ViewModels
{
    public class SquareViewModel
    {
        public int Id { get; set; }
        [DisplayName("Parent State")]
        public int? ParentStateId { get; set; }
        public string? Name { get; set; }
        public string? Color { get; set; }

        [DisplayName("Sentance A")]
        public string? SentenceA { get; set; }
        [DisplayName("Sentance E")]
        public string? SentenceE { get; set; }
        [DisplayName("Sentance I")]
        public string? SentenceI { get; set; }
        [DisplayName("Sentance O")]
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
            var states = new List<SelectListItem>() {
                new SelectListItem()
                {
                    Text = "-- Select --",
                    Value = "0"
                }
            };

            states.AddRange(_stateRepository.GetMany(a => a.SquareId != Id, a => a.Square).Select(a => _mapper.Map<StateViewModel>(a)).Select(a => new SelectListItem()
            {
                Text = String.Format("#{0} {1} - {2}", a.Square.Id, a.Square.Name, WebsiteHelper.GetStateSentance(a.Square, a.StateType)),
                Value = a.Id.ToString()
            }).ToList());

            States = states;
        }

        public Square ToModel(IMapper _mapper)
        {
            var entity = _mapper.Map<Square>(this);
            if(entity.ParentStateId == 0)
            {
                entity.ParentStateId = null;
            }
            entity.States = new List<State>() {
                _mapper.Map<State>(StateAI),
                _mapper.Map<State>(StateEO),
                _mapper.Map<State>(StateIO),
            };

            return entity;
        }
    }
}
