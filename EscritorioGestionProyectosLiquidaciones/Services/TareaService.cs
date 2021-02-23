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
        public List<Tarea> FindTareasSinFinalizarProyecto(int idProyecto)
        {
            using (var dbContext = new TpSeminarioContext())
            {
                return dbContext.Tarea.Where(t => t.Idproyecto == idProyecto && t.finalizada == "false").ToList();
            }
        }

        public List<Tarea> FindTareasFinalizadasProyecto(int idProyecto)
        {
            using (var dbContext = new TpSeminarioContext())
            {
                return dbContext.Tarea.Where(t => t.Idproyecto == idProyecto && t.finalizada == "true").ToList();
            }
        }

        public List<Tarea> FindTareasEmpleado(int idEmpleado)
        {
            using (var dbContext = new TpSeminarioContext())
            {
                return dbContext.Tarea.Where(t => t.Idempleado == idEmpleado).ToList();
            }
        }

        public List<Tarea> FindTareasFinalizadasEmpleado(int idEmpleado)
        {
            using (var dbContext = new TpSeminarioContext())
            {
                return dbContext.Tarea.Where(t => t.Idempleado == idEmpleado && t.finalizada == "true").ToList();
            }
        }

        public void Guardar(Tarea tarea)
        {
            using (var dbContext = new TpSeminarioContext())
            {
                if (tarea.Idtarea != 0)
                {
                    dbContext.Tarea.Update(tarea);
                    dbContext.SaveChanges();
                }
                else
                {
                    dbContext.Tarea.Add(tarea);
                    dbContext.SaveChanges();
                }

            }
        }

        public Tarea FindTarea(int idTarea)
        {
            using (var dbContext = new TpSeminarioContext())
            {
                return dbContext.Tarea.Where(t => t.Idtarea == idTarea).First();
            }
        }

        public void Eliminar(int idTarea)
        {
            using (var dbContext = new TpSeminarioContext())
            {
                var tarea = dbContext.Tarea.Where(t => t.Idtarea == idTarea).First();
                tarea.Id = null;
                tarea.IdproyectoNavigation = null;

                var horas = dbContext.HoraTrabajada.Where(ht => ht.Idtarea == idTarea).ToList();

                foreach (var item in horas)
                {
                    dbContext.HoraTrabajada.Remove(item);
                }

                dbContext.Tarea.Remove(tarea);
                dbContext.SaveChanges();
            }

        }
    }
}
