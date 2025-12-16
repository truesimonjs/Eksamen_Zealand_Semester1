using hillerodSejlklubb.Models;
using hillerodSejlklubb.Services;
using Hillerødsejlklubb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace hillerodSejlklubb.Pages.Bookings
{
    public class CreateModel : PageModel
    {
        private readonly BookingService Service;
        public CreateModel(BookingService s) => Service = s;

        [BindProperty] public Booking NewBooking { get; set; }
        [BindProperty] public DateTime BookingDate { get; set; }
        [BindProperty] public TimeSpan StartTime { get; set; }
        [BindProperty] public TimeSpan EndTime { get; set; }
        public List<Boat> _boats;
        public List<Boat> boats
        {
            get { return _boats; }
            set { _boats = value; }
        }

        public void OnGet()
        {

            BookingDate = DateTime.Today;
            StartTime = new TimeSpan(10, 0, 0); // 10:00
            EndTime = new TimeSpan(12, 0, 0);   // 12:00
            boats = new List<Boat>
            {
                new Boat {_name = "kunde 1 båd"},
                new Boat {_name = "kunde 2 båd"},
                new Boat {_name = "kunde 3 båd"}
            };

        }

        public IActionResult OnPost()
        {
            // Kombiner dato og tid
            NewBooking.Start = BookingDate + StartTime;
            NewBooking.End = BookingDate + EndTime;

            if (NewBooking.Start >= NewBooking.End)
                ModelState.AddModelError("", "Start skal være før slut");

            if (ModelState.IsValid)
            {
                Service.Add(NewBooking);
                return RedirectToPage("Index");
            }
            return Page();
        }
    }
}
