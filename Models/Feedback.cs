using System;
using System.Collections.Generic;

namespace Bas360_MVC.Models
{
    public partial class Feedback
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int Rating { get; set; }
        public string? Review { get; set; }
        public int BookingId { get; set; }

        public virtual Booking Booking { get; set; } = null!;
        public virtual User User { get; set; } = null!;
    }
}
