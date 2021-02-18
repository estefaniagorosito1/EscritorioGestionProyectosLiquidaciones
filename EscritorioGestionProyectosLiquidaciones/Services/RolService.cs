using EscritorioGestionProyectosLiquidaciones.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscritorioGestionProyectosLiquidaciones.Services
{
    class RolService
    {
        public List<Rol> Find()
        {
            using (var dbContext = new TpSeminarioContext())
            {
                return dbContext.Rol.ToList();
            }
        }

        public Rol FindRol(int idRol)
        {
            using (var dbContext = new TpSeminarioContext())
            {
                return dbContext.Rol.Find(idRol);
            }
        }
    }
}
