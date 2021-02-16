using EscritorioGestionProyectosLiquidaciones.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscritorioGestionProyectosLiquidaciones.Services
{
    class PerfilService
    {
        public List<Perfil> FindPerfiles()
        {
            using (var dbContext = new TpSeminarioContext())
            {
                return dbContext.Perfil.ToList();
            }
        }
    }
}
