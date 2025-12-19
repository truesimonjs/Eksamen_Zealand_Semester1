using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using Zealand_semester1_eksamen.Models;
using Zealand_semester1_eksamen.Services;

namespace Zealand_semester1_eksamen.Pages.Events
{
    public class IndexModel : PageModel
    {
        // Reference til vores service
        private EventService _service;

        // Listen som HTML-siden skal vise
        public List<Event> Events { get; set; }

        // Det brugeren skriver i søgefeltet
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }

        // Constructor - her får vi servicen
        public IndexModel(EventService service)
        {
            _service = service;
        }

        public void OnGet()
        {
            // Hvis søgefeltet ikke er tomt, så søg. Ellers vis alt.
            if (!string.IsNullOrEmpty(SearchString))
            {
                Events = _service.SearchEvents(SearchString);
            }
            else
            {
                Events = _service.GetEvents();
            }
        }
    }
}