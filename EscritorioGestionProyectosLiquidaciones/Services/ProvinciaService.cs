using EscritorioGestionProyectosLiquidaciones.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscritorioGestionProyectosLiquidaciones.Services
{
    class ProvinciaService
    {
        public List<Provincia> FindProvincias()
        {
            using (var dbContext = new TpSeminarioContext())
            {
                return dbContext.Provincia.ToList();
            } 
        }
    }
}
