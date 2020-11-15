using System;
using System.Collections.Generic;

namespace school.Models
{
    public partial class Students
    {
        public Students()
        {
            Exams = new HashSet<Exams>();
        }

        public int Id { get; set; }
        public string Indeks { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime? Birthday { get; set; }
        public int? Directionid { get; set; }
        public int? Statusid { get; set; }

        public virtual Directions Direction { get; set; }
        public virtual Status Status { get; set; }
        public virtual ICollection<Exams> Exams { get; set; }
    }
}
