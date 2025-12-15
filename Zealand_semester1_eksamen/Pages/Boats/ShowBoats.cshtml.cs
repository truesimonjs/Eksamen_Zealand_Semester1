using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Zealand_semester1_eksamen.Models;
using Zealand_semester1_eksamen.SJS;

namespace Zealand_semester1_eksamen.Pages.Boats
{
    public class ShowBoatsModel : PageModel
    {
        private IBoatServiceSJS boatService;
        public List<BoatSJS> Boats { get; private set; }
        public ShowBoatsModel(IBoatServiceSJS boatService)
        {
            this.boatService = boatService;
        }

        public void OnGet()
        {
            Boats = boatService.GetBoats();
        }
    }
}
