using Microsoft.AspNetCore.Mvc.Rendering;

namespace SquareOfOpposition.Web.ViewModels
{
    public class SquareViewModel
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public string? SentanceA { get; set; }
        public string? SentanceE { get; set; }
        public string? SentanceI { get; set; }
        public string? SenranceO { get; set; }

        public List<SelectListItem> States { get; set; }

        public StateViewModel StateAI { get; set; }
        public StateViewModel StateEO { get; set; }
        public StateViewModel StateIO { get; set; }

        public SquareViewModel()
        {
            States = new List<SelectListItem>();
            StateAI = new StateViewModel();
            StateEO = new StateViewModel();
            StateIO = new StateViewModel();
        }

        public void Initialize()
        {

        }
    }
}
