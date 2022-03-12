using System;
using System.Collections.Generic;

namespace Bas360_MVC.Models
{
    public partial class Login
    {
        public Login()
        {
            Users = new HashSet<User>();
        }

        public int Id { get; set; }
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;

        public virtual ICollection<User> Users { get; set; }
    }
}
