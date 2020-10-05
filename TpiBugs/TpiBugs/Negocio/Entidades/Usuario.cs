﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpiBugs.Negocio.Entidades

{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public string NombreUsuario { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public Perfil Perfil { get; set; }
        

        public Usuario(string nombre)
        {
            nombre = NombreUsuario;
        }
        public Usuario()
        {
            
        }


        public override string ToString()
        {
            return NombreUsuario;
        }
    }
}
