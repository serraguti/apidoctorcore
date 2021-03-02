using ApiDoctor.Data;
using ApiDoctor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiDoctor.Repositories
{
    public class RepositoryDoctor
    {
        private DoctoresContext context;
        public RepositoryDoctor(DoctoresContext context)
        {
            this.context = context;
        }

        public List<Doctor> GetDoctores()
        {
            return this.context.Doctores.ToList();
        }

        public Doctor BuscarDoctor(int iddoctor)
        {
            return this.context.Doctores
                .SingleOrDefault(x => x.IdDoctor == iddoctor);
        }

        public List<String> GetEspecialidades()
        {
            var consulta = (from datos in this.context.Doctores
                            select datos.Especialidad).Distinct();
            return consulta.ToList();
        }

        public List<Doctor> GetDoctoresEspecialidad(String especialidad)
        {
            return this.context.Doctores.Where(x => x.Especialidad == especialidad).ToList();
        }

        public List<Doctor> GetDoctoresSalario (int salario)
        {
            return this.context.Doctores.Where(x => x.Salario >= salario).ToList();
        }
    }
}
