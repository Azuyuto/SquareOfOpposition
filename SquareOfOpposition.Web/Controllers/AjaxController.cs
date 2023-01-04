using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SquareOfOpposition.Web.Interfaces;
using SquareOfOpposition.Web.ViewModels;

namespace SquareOfOpposition.Web.Controllers
{
    public class AjaxController : Controller
    {
        private readonly IMapper _mapper;
        private readonly ISquareRepository _squareRepository;

        public AjaxController(IMapper mapper, ISquareRepository squareRepository)
        {
            _mapper = mapper;
            _squareRepository = squareRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SquareTable()
        {
            var squareList = _squareRepository.GetAll().Select(s => _mapper.Map<SquareViewModel>(s)).ToList();
            return PartialView(squareList);
        }
    }
}
