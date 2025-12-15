using System;
using System.ComponentModel.DataAnnotations;

namespace Zealand_semester1_eksamen.models
{
    public class Booking
    {
        public int Id { get; set; }

        [Required]
        public string Boat { get; set; }

        [Required]
        public string Member { get; set; }

        [Required]
        public DateTime Start { get; set; }

        [Required]
        public DateTime End { get; set; }

        public string Destination { get; set; }

        public bool IsActive { get; set; } =true;

        public Booking()
        {

        }
    }
}
  

