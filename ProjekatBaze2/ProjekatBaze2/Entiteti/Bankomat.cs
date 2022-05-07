using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatBaze2.Entiteti
{
    public class Bankomat
    {
        public virtual int Id { get; set; } 
        public virtual string Lokacija { get; set; }  
        public virtual string NazivProizvodjaca { get; set; }

        public virtual char Status { get; set; }   
        public virtual DateTime DatumPoslednjegServisa { get; set; }    
        public virtual int BrojFilijala { get; set; }
    }
}
