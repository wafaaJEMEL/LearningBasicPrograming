using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TachProjet_R.Interface;
using TachProjet_R.Models;
using TachProjet_R.Storage;

namespace TachProjet_R.Repository
{
    public class EmployeRepository : IEmployer
    {
        private MyDbContext Dbstx = new MyDbContext();

        public bool AddEmployer(Employer employer)
        {
            this.Dbstx.EmployerTable.Add(employer);
            return true;
        }

        public Boolean AffectTache(int IdEmp, int IdTache)
        {
            Employer emp = (Employer)this.Dbstx.EmployerTable.First(E => E.Id == IdEmp);
            Tache tache = (Tache)this.Dbstx.TacheTable.First(T => T.Id == IdTache);
            tache.Employer = emp;
            emp.Taches.Add(tache);
            this.Dbstx.SaveChanges();
            return true;
        }

        public bool DropEmployer(int Id)
        {
            Employer emprToDrop = (Employer)this.Dbstx.EmployerTable.Where(E => E.Id == Id);
            this.Dbstx.Remove(emprToDrop);
            return true;
        }

        public List<Employer> GetEmployers()
        {
            //Select * from EmployerTable
            return this.Dbstx.EmployerTable.ToList<Employer>();
        }

        public List<Tache> GetEmployerTache(int Id)
        {
            Employer emp = this.Dbstx.EmployerTable.First(a => a.Id == Id);
            return emp.Taches.ToList<Tache>();

        }
    }
}
