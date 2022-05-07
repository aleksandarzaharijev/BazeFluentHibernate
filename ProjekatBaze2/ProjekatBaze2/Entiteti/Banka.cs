using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatBaze2.Entiteti
{
    public class Banka
    {
        public virtual int Id { get; set; }
        public virtual string AdresaCentrale { get; set; }
        public virtual string WebAdresa { get; set; }
        public virtual string Ime { get; set; }
        public virtual string Email { get; set; }   
    }
}
