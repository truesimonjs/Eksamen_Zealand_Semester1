using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Zealand_semester1_eksamen.Models;
using Zealand_semester1_eksamen.Services;

namespace Zealand_semester1_eksamen.Pages.Medlemmer
{
    public class OpretModel : PageModel
    {
        [BindProperty]
        public Medlem Medlem { get; set; } = new();

        public IActionResult OnPost()
        {
            MedlemFil.AddMedlem(Medlem);
            return RedirectToPage("Index");
        }
    }
}
