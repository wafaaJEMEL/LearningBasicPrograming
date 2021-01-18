using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TachProjet_R.Interface;
using TachProjet_R.Models;
using TachProjet_R.Storage;

namespace TachProjet_R.Repository
{
    public class TacheRepository : ITache
    {
        private MyDbContext Dbstx = new MyDbContext();

        public bool AddTache(Tache tache)
        {
            this.Dbstx.TacheTable.Add(tache);
            return true;
        }

        public bool DropTache(int Id)
        {
            Tache tacheDrop = (Tache)this.Dbstx.TacheTable.Where(T => T.Id == Id);
            this.Dbstx.TacheTable.Remove(tacheDrop);
            return true;
        }

        public List<Tache> GetTaches()
        {
            //select * from TacheTable 
            return this.Dbstx.TacheTable.ToList<Tache>();
        }
    }
}
