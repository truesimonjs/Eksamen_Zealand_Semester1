using System;
using System.Collections.Generic;
using System.Linq;
using Zealand_semester1_eksamen.models; // Add this using directive to resolve Booking

namespace Zealand_semester1_eksamen.service
{
    public class BookingService
    {
        private List<Booking> _bookings = new();
        private int _idCounter = 1;

        private Booking FindBooking(int id) => _bookings.FirstOrDefault(b => b.Id == id);

        public void Add(Booking b)
        {
            b.Id = _idCounter++;
            _bookings.Add(b);
        }

        public List<Booking> GetAll() => _bookings.OrderBy(b => b.Start).ToList();

        public List<Booking> GetActive() => _bookings.Where(b => b.IsActive).ToList();

        public void Complete(int id)
        {
            var b = FindBooking(id);
            if (b != null)
                b.IsActive = false;
        }

        // Filtrering (kravet)
        public List<Booking> Filter(string boat) =>
            _bookings.Where(b => b.Boat.Contains(boat, StringComparison.OrdinalIgnoreCase)).ToList();
    }
}
