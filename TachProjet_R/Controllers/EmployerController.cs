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
    [Route("api/employer")]
    [ApiController]
    public class EmployerController : ControllerBase
    {
        private EmployeRepository EmpRep = new EmployeRepository();
        [Route("list")]
        [HttpGet]
        public List<Employer> GetAllEmployer()
        {
            return this.EmpRep.GetEmployers();
        }
       
        [Route("save")]
        [HttpPost]
        public bool NewEmployee(string nom)
        {
            Employer emp = new Employer();
            emp.Name = nom;

         return this.EmpRep.AddEmployer(emp);
          
        }

        [Route("drop/{Id}")]
        [HttpGet]
        public bool dropEmployee(int Id)
        {     
            return this.EmpRep.DropEmployer(Id);
        }

        [Route("appendtask")]
        [HttpPost]
        public bool appendTask(int empId,int idTache)
        {
            return this.EmpRep.AffectTache(empId, idTache);
        }


  
        [Route("getEmployeeTasks/{empId}")]
        [HttpGet]
        public List<Tache> getEmployeeTasks(int empId)
        {

            return this.EmpRep.GetEmployerTache(empId);


        }


    }
}
