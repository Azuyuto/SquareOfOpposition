using Microsoft.AspNetCore.Mvc;
using SquareOfOpposition.Web.ViewModels;

namespace SquareOfOpposition.Web.Controllers
{
    public class AjaxController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SquareTable()
        {
            var squareList = new List<SquareViewModel>();
            squareList.Add(new SquareViewModel()
            {
                ID = 1,
                Name = "Square 1"
            });
            squareList.Add(new SquareViewModel()
            {
                ID = 2,
                Name = "Square 2"
            });
            return PartialView(squareList);
        }
    }
}
