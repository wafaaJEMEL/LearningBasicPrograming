using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TachProjet_R.Models;

namespace TachProjet_R.Interface
{
    public interface ITache
    {
        public List<Tache> GetTaches();

        public Boolean AddTache(Tache tache);

        public Boolean DropTache(int Id);

       
    }
}
