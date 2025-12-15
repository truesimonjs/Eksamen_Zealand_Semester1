
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Zealand_semester1_eksamen.models;
using Zealand_semester1_eksamen.service;

namespace Zealand_semester1_eksamen.pages.Bookingss
{
    public class IndexModel : PageModel
    {
        private readonly BookingService _service;

        public IndexModel(BookingService s) => _service = s;

        [BindProperty]
        public string SearchBoat { get; set; }

        public List<Booking> Bookings { get; set; }

        public void OnGet() => Bookings = _service.GetAll();

        public IActionResult OnPostComplete(int id)
        {
            _service.Complete(id);
            return RedirectToPage();
        }

        public IActionResult OnPostSearch()
        {
            Bookings = string.IsNullOrEmpty(SearchBoat)
                ? _service.GetAll()
                : _service.Filter(SearchBoat);
            return Page();
        }
    }
}
