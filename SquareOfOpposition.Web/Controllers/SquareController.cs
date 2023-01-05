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

        public SquareController(IMapper mapper, ISquareRepository squareRepository, IStateTransitionRepository stateTransitionRepository)
        {
            _mapper = mapper;
            _squareRepository = squareRepository;
            _stateTransitionRepository = stateTransitionRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Add()
        {
            var vm = new SquareViewModel();
            return View("SquareForm", vm);
        }

        public IActionResult Edit(int id)
        {
            var vm = _mapper.Map<SquareViewModel>(_squareRepository.GetMany(a => a.Id == id, a => a.States).First());
            return View("SquareForm", vm);
        }

        public IActionResult Save(SquareViewModel vm)
        {
            if (ModelState.IsValid)
            {
                _squareRepository.AddOrUpdate(vm.ToModel(_mapper));
                return RedirectToAction("Index", "State");
            }
            return View("SquareForm", vm);
        }

        public IActionResult Remove(int id)
        {
            var square = _squareRepository.GetMany(a => a.Id == id, a => a.States).First();
            _stateTransitionRepository.RemoveBySquare(square);
            _squareRepository.Remove(square);
            _squareRepository.SaveChanges();
            return RedirectToAction("Index", "State");
        }
    }
}
