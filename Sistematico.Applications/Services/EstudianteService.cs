using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Sistematico.Applications.Interfaces;
using Sistematico.Domain.Entities;
using Sistematico.Domain.Interfaces;

namespace Sistematico.Applications.Services
{
    public class EstudianteService : IEstudianteService
    {
        IEstudianteRepository estudianteRepository;
        public EstudianteService(IEstudianteRepository estudianteRepository)
        {
            this.estudianteRepository = estudianteRepository;
        }
        public void Create(Estudiante t)
        {
            if (t == null)
            {
                throw new ArgumentNullException("El Asset no puede ser null.");
            }

            estudianteRepository.Create(t);
        }

        public bool Delete(Estudiante t)
        {
            return estudianteRepository.Delete(t);
           
        }

        public Estudiante FindByCarnet(string carnet)
        {
            return estudianteRepository.FindByCarnet(carnet);
        }

        public IEnumerable<Estudiante> FindByLastnames(string lastnames)
        {
            return estudianteRepository.FindByLastnames(lastnames);
        }

        public Estudiante FindByName(string name)
        {
            return estudianteRepository.FindByName(name);
        }

        public List<Estudiante> GetAll()
        {
            return estudianteRepository.GetAll();
        }

        public int Update(Estudiante t)
        {
            return estudianteRepository.Update(t);
        }
    }
}
