using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TachProjet_R.Models;

namespace TachProjet_R.Interface
{
    public interface IEmployer
    {
        /// <summary>
        /// get employer
        /// </summary>
        /// <returns></returns>
        public List<Employer> GetEmployers();

        /// <summary>
        /// affect tache to EMp
        /// </summary>
        /// <param name="IdEmp"></param>
        /// <param name="IdTache"></param>
        public Boolean AffectTache(int IdEmp, int IdTache);

        /// <summary>
        /// Ajouter Employer
        /// </summary>
        public Boolean AddEmployer(Employer employer);

        public Boolean DropEmployer(int Id);

        public List<Tache> GetEmployerTache(int Id);
    }
}
