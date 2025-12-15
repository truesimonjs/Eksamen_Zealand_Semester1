using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Zealand_semester1_eksamen.Models;
using Zealand_semester1_eksamen.SJS;

namespace Zealand_semester1_eksamen.Pages.Boats
{
    public class ShowBoatsModel : PageModel
    {
        public List<Boat> Boats { get; private set; }
        public void OnGet()
        {
            Boats = MockBoat.Boats;
        }
    }
}
