using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Zealand_semester1_eksamen.Models;
using Zealand_semester1_eksamen.Services;

namespace Zealand_semester1_eksamen.Pages.Medlemmer
{
    public class SletModel : PageModel
    {
        [BindProperty]
        public Medlem Medlem { get; set; } = new();

        public void OnGet(int id)
        {
            Medlem = MedlemFil.GetById(id);
        }

        public IActionResult OnPost()
        {
            MedlemFil.DeleteMedlem(Medlem.MedlemId);
            return RedirectToPage("Index");
        }
    }
}
