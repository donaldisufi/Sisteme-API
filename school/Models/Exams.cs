using System;
using System.Collections.Generic;

namespace school.Models
{
    public partial class Exams
    {
        public int Id { get; set; }
        public int Studentid { get; set; }
        public int Subjectid { get; set; }
        public int Afatiid { get; set; }
        public int Proffesorid { get; set; }
        public int? Points { get; set; }
        public int? Grade { get; set; }

        public virtual Afatet Afati { get; set; }
        public virtual Proffesors Proffesor { get; set; }
        public virtual Students Student { get; set; }
        public virtual Subjects Subject { get; set; }
    }
}
