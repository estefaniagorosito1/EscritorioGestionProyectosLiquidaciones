using System;
using System.Collections.Generic;

namespace EscritorioGestionProyectosLiquidaciones.Models
{
    public partial class EscalaAntiguedad
    {
        public EscalaAntiguedad()
        {
            Liquidacion = new HashSet<Liquidacion>();
        }

        public int IdescalaAntiguedad { get; set; }
        public int CantidadAnios { get; set; }
        public double PorcentajeAumentoAnt { get; set; }

        public ICollection<Liquidacion> Liquidacion { get; set; }
    }
}
