﻿using System;
using System.Collections.Generic;

namespace EscritorioGestionProyectosLiquidaciones.Models
{
    public partial class Rol
    {
        public Rol()
        {
            Usuario = new HashSet<Usuario>();
        }

        public int Idrol { get; set; }
        public string DescripcionRol { get; set; }

        public ICollection<Usuario> Usuario { get; set; }
    }
}
