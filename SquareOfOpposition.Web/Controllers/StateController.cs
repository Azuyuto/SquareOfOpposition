using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SquareOfOpposition.Web.Interfaces;
using SquareOfOpposition.Web.Repository;
using SquareOfOpposition.Web.ViewModels;

namespace SquareOfOpposition.Web.Controllers
{
    public class StateController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IStateRepository _stateRepository;

        public StateController(IMapper mapper, IStateRepository stateRepository)
        {
            _mapper = mapper;
            _stateRepository = stateRepository;
        }

        public IActionResult Index(int parentStateId = 0)
        {
            var vm = new StateListViewModel()
            {
                ParentStateId = parentStateId
            };
            vm.Initialize(_mapper, _stateRepository);

            return View(vm);
        }
    }
}
