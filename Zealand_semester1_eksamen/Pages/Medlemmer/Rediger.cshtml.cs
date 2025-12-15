using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Zealand_semester1_eksamen.Models;
using Zealand_semester1_eksamen.Services;

namespace Zealand_semester1_eksamen.Pages.Medlemmer
{
    public class RedigerModel : PageModel
    {
        [BindProperty]
        public Medlem Medlem { get; set; } = new();

        public void OnGet(int id)
        {
            Medlem = MedlemFil.GetById(id);
        }

        public IActionResult OnPost()
        {
            MedlemFil.UpdateMedlem(Medlem.MedlemId, Medlem.Navn, Medlem.Email);
            return RedirectToPage("Index");
        }
    }
}
