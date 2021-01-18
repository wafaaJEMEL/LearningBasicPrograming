using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TachProjet_R.Models
{
    public class Employer
    {
       

        public int Id {get; set; }

        public string Name {get; set;}

        public ICollection<Tache> Taches {get; set;}


       
    }
}
