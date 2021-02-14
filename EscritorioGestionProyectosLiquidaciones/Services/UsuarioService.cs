﻿using EscritorioGestionProyectosLiquidaciones.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscritorioGestionProyectosLiquidaciones.Services
{
    class UsuarioService
    {
        public Usuario FindUsuario(string user, string pass)
        {
            using (var dbContext = new TpSeminarioContext())
            {
                Usuario usuario = dbContext.Usuario
                                            .Where(u => u.NombreUsuario.Equals(user) && u.PasswordUsuario.Equals(pass))
                                            .FirstOrDefault();
                return usuario;
            }
        }
    }
}
