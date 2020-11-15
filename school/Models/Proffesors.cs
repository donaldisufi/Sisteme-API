using System;
using System.Collections.Generic;

namespace school.Models
{
    public partial class Proffesors
    {
        public Proffesors()
        {
            Exams = new HashSet<Exams>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int? Subjectid { get; set; }

        public virtual Subjects Subject { get; set; }
        public virtual ICollection<Exams> Exams { get; set; }
    }
}
