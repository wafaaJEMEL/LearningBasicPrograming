using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TachProjet_R.Models;
using TachProjet_R.Repository;

namespace TachProjet_R.Controllers
{
    [Route("api/tache")]
    [ApiController]
    public class TacheController : ControllerBase
    {
        private TacheRepository tacheR = new TacheRepository();
        [Route("save")]
        [HttpPost]
        public bool NewTAche(string Ds)
        {
            Tache tache = new Tache();
            tache.Deseigniation = Ds;
            return this.tacheR.AddTache(tache);

        }
        [Route("list")]
        [HttpGet]
        public List<Tache> GetAllTache()
        {
            return this.tacheR.GetTaches();
        }

        [Route("drop/{Id}")]
        [HttpPost]
        public bool dropEmployee(int Id)
        {
            return this.tacheR.DropTache(Id); ;
        }
    }
}
