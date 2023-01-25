using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SquareOfOpposition.Web.Interfaces;
using SquareOfOpposition.Web.Models.Domain;
using SquareOfOpposition.Web.Repository;
using SquareOfOpposition.Web.ViewModels;

namespace SquareOfOpposition.Web.Controllers
{
    public class SquareController : Controller
    {
        private readonly IMapper _mapper;
        private readonly ISquareRepository _squareRepository;
        private readonly IStateTransitionRepository _stateTransitionRepository;
        private readonly IStateRepository _stateRepository;
        private readonly ISquareService _squareService;

        public SquareController(IMapper mapper, ISquareRepository squareRepository, IStateTransitionRepository stateTransitionRepository, 
            IStateRepository stateRepository, ISquareService squareService)
        {
            _mapper = mapper;
            _squareRepository = squareRepository;
            _stateTransitionRepository = stateTransitionRepository;
            _stateRepository = stateRepository;
            _squareService = squareService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Add(int? parentStateId = null)
        {
            var vm = new SquareViewModel() 
            { 
                ParentStateId = parentStateId
            };
            vm.Initialize(_mapper, _stateRepository);
            return View("SquareForm", vm);
        }

        public IActionResult Edit(int id)
        {
            var vm = _mapper.Map<SquareViewModel>(_squareRepository.GetMany(a => a.Id == id, a => a.States).First());
            vm.Initialize(_mapper, _stateRepository);
            return View("SquareForm", vm);
        }

        public IActionResult Save(SquareViewModel vm)
        {
            if (ModelState.IsValid)
            {
                _squareService.AddOrUpdate(vm.ToModel(_mapper));
                return RedirectToAction("Index", "State", new { parentStateId = vm.ParentStateId });
            }
            vm.Initialize(_mapper, _stateRepository);
            return View("SquareForm", vm);
        }

        public IActionResult Remove(int id)
        {
            _squareService.Remove(id);
            return RedirectToAction("Index", "State");
        }
    }
}
