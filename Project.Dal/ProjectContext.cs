using Microsoft.EntityFrameworkCore;
using Project.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Dal
{
    public class ProjectContext:DbContext
    {
        public ProjectContext(DbContextOptions<ProjectContext> db) : base(db)
        {

        }
        public DbSet<Personel> Personel { get; set; }
    }
}
