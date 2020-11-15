using System;
using System.Collections.Generic;

namespace school.Models
{
    public partial class Status
    {
        public Status()
        {
            Students = new HashSet<Students>();
        }

        public int Id { get; set; }
        public string Status1 { get; set; }

        public virtual ICollection<Students> Students { get; set; }
    }
}
