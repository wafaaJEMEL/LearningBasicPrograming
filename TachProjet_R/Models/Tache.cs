using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TachProjet_R.Models
{
    public class Tache
    {
       
        public int Id {get; set;}

        public string Deseigniation {get; set;}

        public Employer Employer {get; set;}

       
    }
}
