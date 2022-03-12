using System;
using System.Collections.Generic;

namespace Bas360_MVC.Models
{
    public partial class Product
    {
        public Product()
        {
            Bookings = new HashSet<Booking>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public decimal Cost { get; set; }
        public int StockAvailability { get; set; }
        public int CreatedByUserId { get; set; }

        public virtual User CreatedByUser { get; set; } = null!;
        public virtual ICollection<Booking> Bookings { get; set; }
    }
}
