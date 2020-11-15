using System;
using System.Collections.Generic;

namespace school.Models
{
    public partial class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int? RoleId { get; set; }
        public DateTime? LastLogin { get; set; }
        public string Token { get; set; }

        public virtual Role Role { get; set; }
    }
}
