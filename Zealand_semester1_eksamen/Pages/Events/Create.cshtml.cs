using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Zealand_semester1_eksamen.Models;
using Zealand_semester1_eksamen.Services;

namespace Zealand_semester1_eksamen.Pages.Events
{
    public class CreateModel : PageModel
    {
        private EventService _service;

        [BindProperty]
        public Event NyEvent { get; set; }

        public CreateModel(EventService service)
        {
            _service = service;
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

            _service.AddEvent(NyEvent);

            // Gå tilbage til oversigten
            return RedirectToPage("Index");
        }
    }
}