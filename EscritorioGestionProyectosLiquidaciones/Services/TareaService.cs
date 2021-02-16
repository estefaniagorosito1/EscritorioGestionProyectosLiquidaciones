using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EscritorioGestionProyectosLiquidaciones.Models;

namespace EscritorioGestionProyectosLiquidaciones.Services
{
    class TareaService
    {
        public List<Tarea> FindTareasProyecto(int idProyecto)
        {
            using (var dbContext = new TpSeminarioContext())
            {
                return dbContext.Tarea.Where(t => t.Idproyecto == idProyecto).ToList();
            }
        }

        public List<Tarea> FindTareasEmpleado(int idEmpleado)
        {
            using (var dbContext = new TpSeminarioContext())
            {
                return dbContext.Tarea.Where(t => t.Idempleado == idEmpleado).ToList();
            }
        }
    }
}
