using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Zealand_semester1_eksamen.Models;
using Zealand_semester1_eksamen.Services;
using Zealand_semester1_eksamen.SJS;

namespace Zealand_semester1_eksamen.Pages
{
    public class BoatMaintenanceSJSModel : PageModel
    {
        [BindProperty]
        public string Maintenance { get; set; }
        [BindProperty]
        public int BoatId { get; set; }
        private IBoatServiceSJS boatService;
        public BoatSJS Boat
        {
            get
            {
                return boatService.GetBoat(BoatId);
            }
        }
      
    
        public void OnGet(int id)
        {
            
            BoatId = id;
        }
        public BoatMaintenanceSJSModel(IBoatServiceSJS boatService)
        {
            this.boatService = boatService;
        }
        public IActionResult OnPost()
        {
            
            if (!ModelState.IsValid)
            {

                return Page();
            }
            Boat.MaintenanceLogs.Add(Maintenance);
            return RedirectToPage("ShowBoats");

        }
    }
}
