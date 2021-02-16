using EscritorioGestionProyectosLiquidaciones.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscritorioGestionProyectosLiquidaciones.Services
{
    class ProyectoService
    {
        public List<Proyecto> Find()
        {
            using (var dbContext = new TpSeminarioContext())
            {
                return dbContext.Proyecto.ToList();
            }
        }

        public void Guardar(Proyecto proyecto)
        {
            using (var dbContext = new TpSeminarioContext())
            {
                if (proyecto.Idproyecto != 0)
                {
                    dbContext.Proyecto.Update(proyecto);
                    dbContext.SaveChanges();
                }
                else
                {
                    dbContext.Proyecto.Add(proyecto);
                    dbContext.SaveChanges();
                }
            }
        }

        public void Eliminar(int idProyecto)
        {
            using (var dbContext = new TpSeminarioContext())
            {
                var proyecto = dbContext.Proyecto.Find(idProyecto);
                dbContext.Proyecto.Remove(proyecto);

                dbContext.SaveChanges();
            }
        }
    }
}
