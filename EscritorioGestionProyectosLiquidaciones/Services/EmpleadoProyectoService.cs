using EscritorioGestionProyectosLiquidaciones.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscritorioGestionProyectosLiquidaciones.Services
{
    class EmpleadoProyectoService
    {

        public void Guardar(List<EmpleadoProyecto> empleadosProyecto)
        {
            using (var dbContext = new TpSeminarioContext())
            {
                foreach (var item in empleadosProyecto)
                {
                    dbContext.EmpleadoProyecto.Add(item);
                }

                dbContext.SaveChanges();

            }
        }

        public void Eliminar(EmpleadoProyecto empleadoProyecto)
        {
            using (var dbContext = new TpSeminarioContext())
            {
                dbContext.EmpleadoProyecto.Remove(empleadoProyecto);
                dbContext.SaveChanges();
            }
        }

        public List<Empleado> FindEmpleadosProyecto(int IdProyecto)
        {
            using (var dbContext = new TpSeminarioContext())
            {
                var empleadosProyecto = dbContext.EmpleadoProyecto
                                                 .Where(ep => ep.Idproyecto == IdProyecto)
                                                 .Select(ep => ep.Idempleado)
                                                 .ToList();

                List<Empleado> empleados = new List<Empleado>();

                foreach (var item in empleadosProyecto)
                {
                    var empleado = dbContext.Empleado.Find(item);
                    empleados.Add(empleado);
                }

                return empleados;
            }
        }
    }
}
