using Microsoft.AspNetCore.Mvc;
using SquareOfOpposition.Web.ViewModels;

namespace SquareOfOpposition.Web.Controllers
{
    public class SquareController : Controller
    {
        public IActionResult Add()
        {
            var vm = new SquareViewModel();
            return View("SquareForm", vm);
        }

        public IActionResult Edit(int id)
        {
            return View();
        }

        public IActionResult Save(SquareViewModel vm)
        {
            if (ModelState.IsValid)
            {
                // TODO: save
            }
            return View("SquareForm", vm);
        }

        public JsonResult Remove()
        {
            return Json(new { success = true});
        }
    }
}
