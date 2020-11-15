using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using school.Models;

namespace school.Data
{
    public class schoolContext : DbContext
    {
        public schoolContext (DbContextOptions<schoolContext> options)
            : base(options)
        {
        }

        public DbSet<school.Models.Afatet> Afatet { get; set; }

        public DbSet<school.Models.Status> Status { get; set; }



        public virtual DbSet<Directions> Directions { get; set; }
        public virtual DbSet<Exams> Exams { get; set; }
        public virtual DbSet<Proffesors> Proffesors { get; set; }
        public virtual DbSet<Students> Students { get; set; }
        public virtual DbSet<Subjects> Subjects { get; set; }
        public virtual DbSet<User> User { get; set; }
        public DbSet<school.Models.Role> Role { get; set; }
    }
}
