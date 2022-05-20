using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Sistematico.Applications.Interfaces;
using Sistematico.Domain.Entities;
using Sistematico.Domain.Interfaces;

namespace Sistematico.Infraestructure.Repository
{
    public class EFEstudianteRepository : IEstudianteRepository
    {
        public ISistematicoContext sistematicoContext;

        public EFEstudianteRepository(ISistematicoContext sistematicoContext)
        {
            this.sistematicoContext = sistematicoContext;
        }
        public void Create(Estudiante t)
        {
            try
            {
                sistematicoContext.Estudiantes.Add(t);
                sistematicoContext.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Delete(Estudiante t)
        {
            try
            {
                if (t == null)
                {
                    throw new ArgumentNullException("El objeto estudiante no puede ser null.");
                }

                Estudiante estudiante = FindByCarnet(t.Carnet);
                if (estudiante == null)
                {
                    throw new Exception($"El estudiante con carnet  {t.Carnet} no existe.");
                }

                sistematicoContext.Estudiantes.Remove(estudiante);
                int result = sistematicoContext.SaveChanges();

                return result > 0;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Estudiante FindByCarnet(string carnet)
        {
            try
{
                if (string.IsNullOrWhiteSpace(carnet))
                {
                    throw new Exception($"El carnet no puede ser null o estar vacio.");
}

                return sistematicoContext.Estudiantes.FirstOrDefault(x => x.Carnet.Equals(carnet));
            }
            catch
            {
                throw;
            }
        }

        public IEnumerable<Estudiante> FindByLastnames(string lastnames)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(lastnames))
                {
                    throw new Exception($"El parametro lastname '{lastnames}' no tiene el formato correcto.");
                }

                return sistematicoContext.Estudiantes
                                        .Where(x => x.Apellidos.Equals(lastnames, StringComparison.CurrentCultureIgnoreCase))
                                        .ToList();
            }
            catch
            {
                throw;
            }
        }

        public Estudiante FindByName(string name)
{
try
{
                if (string.IsNullOrWhiteSpace(name))
                {
                    throw new Exception($"No se encontro ningun estudiante con este nombre.");
}

                return sistematicoContext.Estudiantes.FirstOrDefault(x => x.Nombres.Equals(name));
            }
            catch
            {
                throw;
            }
        }

        public List<Estudiante> GetAll()
        {
            return sistematicoContext.Estudiantes.ToList();
        }

        public int Update(Estudiante t)
        {
            try
            {
                if (t == null)
                {
                    throw new ArgumentNullException("El estudiante no puede ser null.");
                }

                Estudiante estudiante = FindByCarnet(t.Carnet);
                if (estudiante == null)
                {
                    throw new Exception($"El estudiante con carnet {t.Carnet} no existe.");
                }

                estudiante.Nombres = t.Nombres;
                estudiante.Apellidos = t.Apellidos;
                estudiante.Direccion = t.Direccion;
                estudiante.Phone = t.Phone;
                estudiante.Matematicas = t.Matematicas;
                estudiante.Contabilidad = t.Contabilidad;
                estudiante.Programacion = t.Programacion;
                estudiante.Estadistica = t.Estadistica;
                //employee.Dni = t.Dni;
                //estudiante.Status = t.Status;

                sistematicoContext.Estudiantes.Update(estudiante);
                return sistematicoContext.SaveChanges();
            }
            catch
            {
                throw;
            }
        }
    }

        
    }

