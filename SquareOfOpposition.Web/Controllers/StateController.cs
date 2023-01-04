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

        public IActionResult Index()
        {
            var vm = _stateRepository.GetAll(a => a.Square, a => a.OutTransitions).Select(a => _mapper.Map<StateViewModel>(a));
            return View(vm);
        }
    }
}
