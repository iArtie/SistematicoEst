using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Sistematico.Domain.Entities;

namespace Sistematico.Domain.Interfaces
{
    public interface IEstudianteRepository : IRepository<Estudiante>
    {
        Estudiante FindByCarnet(string carnet);
        Estudiante FindByName(string name);
        IEnumerable<Estudiante> FindByLastnames(string lastnames);
    }
}
