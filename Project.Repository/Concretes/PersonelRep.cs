using Project.Dal;
using Project.Entity;
using Project.Repository.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Repository.Concretes
{
    public class PersonelRep<T> : BaseRepository<Personel>, IPersonelRep where T : class
    {
        public PersonelRep(ProjectContext db) : base(db)
        {
        }
    }
}
