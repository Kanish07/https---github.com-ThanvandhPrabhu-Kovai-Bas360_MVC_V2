using System;
using System.Collections.Generic;

namespace Bas360_MVC.Models
{
    public partial class Role
    {
        public Role()
        {
            Users = new HashSet<User>();
        }

        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string? Descriptions { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}
