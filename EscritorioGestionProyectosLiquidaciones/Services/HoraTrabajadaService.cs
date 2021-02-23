using EscritorioGestionProyectosLiquidaciones.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscritorioGestionProyectosLiquidaciones.Services
{
    class HoraTrabajadaService
    {
        public int GetCantHorasAdeudadasProyecto(int IdProyecto)
        {
            using (var dbContext = new TpSeminarioContext())
            {
                var horas = dbContext.HoraTrabajada
                                      .Where(ht => ht.Idproyecto.Equals(IdProyecto)
                                             && ht.EstadoHoraTrabajada == "ADEUDADAS");

                return horas.Sum(x => x.CantidadHoraTrabajada);
            }
        }

        public int GetCantHorasTrabajadasProyectoPerfil(int IdProyecto, int IdPerfil)
        {
            using (var dbContext = new TpSeminarioContext())
            {

                var horas = dbContext.HoraTrabajada.Where(ht => ht.Idproyecto == IdProyecto
                                                           && ht.Idperfil == IdPerfil);

                return horas.Sum(x => x.CantidadHoraTrabajada);
            }
        }

        public int GetCantHorasOverbudgetProyecto(int idProyecto)
        {
            using (var dbContext = new TpSeminarioContext())
            {
                var horas = dbContext.Tarea.Where(t => t.Idproyecto == idProyecto).Select(t => t.HorasOverbudget).Sum();

                return (int) horas;
            }
        }

        public void CrearHoraTrabajada(HoraTrabajada horaTrabajada)
        {
            using (var dbContext = new TpSeminarioContext())
            {
                dbContext.HoraTrabajada.Add(horaTrabajada);
                dbContext.SaveChanges();
            }
        }

    }
}
