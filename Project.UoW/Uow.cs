using Project.Dal;
using Project.Repository.Abstracts;
using Project.Uow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.UoW
{
    public class Uow : IUow
    {
        ProjectContext _db;
        public IPersonelRep _personelRep { get; private set; }

        public Uow(ProjectContext db, IPersonelRep personelRep)
        {
            _db = db;
            _personelRep = personelRep;
        }
        
        public void Commit()
        {
           _db.SaveChanges();
        }
       
    }
}
