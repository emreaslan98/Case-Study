using Project.Repository.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Uow
{
    public interface IUow
    {
        IPersonelRep _personelRep { get; }
        void Commit();
    }
}
