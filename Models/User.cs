using System;
using System.Collections.Generic;

namespace Bas360_MVC.Models
{
    public partial class User
    {
        public User()
        {
            Bookings = new HashSet<Booking>();
            Feedbacks = new HashSet<Feedback>();
            Products = new HashSet<Product>();
            Transactions = new HashSet<Transaction>();
        }

        public int Id { get; set; }
        public int LoginId { get; set; }
        public string UserName { get; set; } = null!;
        public string Phone { get; set; } = null!;
        public string AltPhone { get; set; } = null!;
        public string Mail { get; set; } = null!;
        public string Address { get; set; } = null!;
        public int RoleId { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime LastLogin { get; set; }

        public virtual Login Login { get; set; } = null!;
        public virtual Role Role { get; set; } = null!;
        public virtual ICollection<Booking> Bookings { get; set; }
        public virtual ICollection<Feedback> Feedbacks { get; set; }
        public virtual ICollection<Product> Products { get; set; }
        public virtual ICollection<Transaction> Transactions { get; set; }
    }
}
