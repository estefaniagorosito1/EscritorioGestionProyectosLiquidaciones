using System;
using System.Collections.Generic;

namespace EscritorioGestionProyectosLiquidaciones.Models
{
    public partial class Provincia
    {
        public Provincia()
        {
            Localidad = new HashSet<Localidad>();
        }

        public long Idprovincia { get; set; }
        public string Descripcion { get; set; }

        public ICollection<Localidad> Localidad { get; set; }
    }
}
