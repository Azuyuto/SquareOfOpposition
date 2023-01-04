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

        public SquareController(IMapper mapper, ISquareRepository squareRepository)
        {
            _mapper = mapper;
            _squareRepository = squareRepository;
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
            var vm = _mapper.Map<SquareViewModel>(_squareRepository.GetById(id));
            return View("SquareForm", vm);
        }

        public IActionResult Save(SquareViewModel vm)
        {
            if (ModelState.IsValid)
            {
                _squareRepository.AddOrUpdate(_mapper.Map<Square>(vm));
                return RedirectToAction("Index");
            }
            return View("SquareForm", vm);
        }

        public IActionResult Remove(int id)
        {
            _squareRepository.Remove(_squareRepository.GetById(id));
            _squareRepository.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
