using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using Zealand_semester1_eksamen.Models;
using Zealand_semester1_eksamen.Services;

namespace Zealand_semester1_eksamen.Pages.Medlemmer
{
    public class IndexModel : PageModel
    {
        public List<Medlem> Medlemmer { get; set; } = new();

        public void OnGet()
        {
            // Test data (only first time)
            if (MedlemFil.GetAll().Count == 0)
            {
                MedlemFil.AddMedlem(new Medlem { MedlemId = 1, Navn = "Anna", Email = "anna@test.dk" });
                MedlemFil.AddMedlem(new Medlem { MedlemId = 2, Navn = "Peter", Email = "peter@test.dk" });
            }

            Medlemmer = MedlemFil.GetAll();
        }
    }
}
