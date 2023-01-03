using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Entity
{
    public class Personel: BaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string University { get; set; }
        public string Department { get; set; }
        public string Gender { get; set; }
        public bool Liability { get; set; } //zimmet

    }
}
