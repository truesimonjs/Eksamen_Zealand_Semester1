using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Zealand_semester1_eksamen.Models;
using Zealand_semester1_eksamen.SJS;

namespace Zealand_semester1_eksamen.Pages.Boats
{
    public class CreateBoatSJSModel : PageModel
    {
        private IBoatServiceSJS boatService;
        [BindProperty]
        public BoatSJS boat { get; set; }
        public CreateBoatSJSModel(IBoatServiceSJS boatService)
        {
            this.boatService = boatService;
        }
        public IActionResult OnGet()
        {
            return Page();
        }
        public IActionResult OnPost()
        {

            if (!ModelState.IsValid)
            {

                return Page();
            }
            boatService.AddBoat(boat);
            return RedirectToPage("ShowBoats");

        }
    }
}
