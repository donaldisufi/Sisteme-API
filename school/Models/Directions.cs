using System;
using System.Collections.Generic;

namespace school.Models
{
    public partial class Directions
    {
        public Directions()
        {
            Students = new HashSet<Students>();
            Subjects = new HashSet<Subjects>();
        }

        public int Id { get; set; }
        public string Direction { get; set; }

        public virtual ICollection<Students> Students { get; set; }
        public virtual ICollection<Subjects> Subjects { get; set; }
    }
}
