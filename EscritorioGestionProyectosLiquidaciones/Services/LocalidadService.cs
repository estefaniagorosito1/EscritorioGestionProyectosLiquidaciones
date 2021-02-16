using EscritorioGestionProyectosLiquidaciones.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscritorioGestionProyectosLiquidaciones.Services
{
    class LocalidadService
    {
        public List<Localidad> FindLocalidadesProvincia(long IdProvincia)
        {
            using (var dbContext = new TpSeminarioContext())
            {
                var localidades = dbContext.Localidad
                                            .Where(l => l.Idprovincia == IdProvincia)
                                            .ToList();

                return localidades;
            }
        }

        public Localidad FindLocalidad(long IdLocalidad)
        {
            using (var dbContext = new TpSeminarioContext())
            {
                return dbContext.Localidad.Find(IdLocalidad);
            }
        }

        public Provincia FindProvinciaByLocalidad(long IdLocalidad)
        {
            using (var dbContext = new TpSeminarioContext())
            {
                return dbContext.Localidad.Where(l => l.Idlocalidad == IdLocalidad).Select(l => l.IdprovinciaNavigation).First();

            }

        }

    }
}
