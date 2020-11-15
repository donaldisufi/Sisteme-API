using System;
using System.Collections.Generic;

namespace school.Models
{
    public partial class Subjects
    {
        public Subjects()
        {
            Exams = new HashSet<Exams>();
            Proffesors = new HashSet<Proffesors>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Semestri { get; set; }
        public int? Directionid { get; set; }

        public virtual Directions Direction { get; set; }
        public virtual ICollection<Exams> Exams { get; set; }
        public virtual ICollection<Proffesors> Proffesors { get; set; }
    }
}
