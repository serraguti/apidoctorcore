using ApiDoctor.Models;
using ApiDoctor.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiDoctor.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctoresController : ControllerBase
    {
        RepositoryDoctor repo;

        public DoctoresController(RepositoryDoctor repo)
        {
            this.repo = repo;
        }

        [HttpGet]
        public ActionResult<List<Doctor>> GetDoctores()
        {
            return this.repo.GetDoctores();
        }

        [HttpGet("{id}")]
        public ActionResult<Doctor> BuscarDoctor(int id)
        {
            return this.repo.BuscarDoctor(id);
        }

        [HttpGet]
        [Route("[action]")]
        public ActionResult<List<String>> Especialidades()
        {
            return this.repo.GetEspecialidades();
        }

        [HttpGet]
        [Route("[action]/{especialidad}")]
        public ActionResult<List<Doctor>> DoctoresEspecialidad(String especialidad)
        {
            return this.repo.GetDoctoresEspecialidad(especialidad);
        }

        [HttpGet]
        [Route("{salario}/{especialidad}")]
        public ActionResult<List<Doctor>> DoctoresSalario(int salario, String especialidad)
        {
            return this.repo.GetDoctoresSalario(salario);
        }
    }
}
