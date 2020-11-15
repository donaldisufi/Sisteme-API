using System;
using System.Collections.Generic;

namespace school.Models
{
    public partial class Afatet
    {
        public Afatet()
        {
            Exams = new HashSet<Exams>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Exams> Exams { get; set; }
    }
}
