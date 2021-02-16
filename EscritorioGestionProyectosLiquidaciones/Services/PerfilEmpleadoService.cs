using EscritorioGestionProyectosLiquidaciones.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscritorioGestionProyectosLiquidaciones.Services
{
    class PerfilEmpleadoService
    {
        public void AsignarPerfilesEmpleado(List<PerfilEmpleado> perfilesEmpleado)
        {
            using (var dbContext = new TpSeminarioContext())
            {
                var perfiles = dbContext.PerfilEmpleado
                                            .Where(pe => pe.Idempleado.Equals(perfilesEmpleado[0].Idempleado))
                                            .ToList();

                foreach (var item in perfiles)
                {
                    dbContext.PerfilEmpleado.Remove(item);
                }

                foreach (var item in perfilesEmpleado)
                {
                    dbContext.PerfilEmpleado.Add(item);
                }

                dbContext.SaveChanges();
            }

        }

        public List<Perfil> FindPerfilesEmpleado(int IdEmpleado)
        {
            using (var dbContext = new TpSeminarioContext())
            {
                List<Perfil> perfiles = new List<Perfil>();
                var perfileEmpleado = dbContext.PerfilEmpleado.Where(pe => pe.Idempleado == IdEmpleado).Select(pe => pe.Idperfil).ToList();

                foreach (var item in perfileEmpleado)
                {
                    var perfil = dbContext.Perfil.Find(item);

                    if (!perfiles.Contains(perfil))
                    {
                        perfiles.Add(perfil);
                    }
                }

                return perfiles;

            }
        }

    }
}
