﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Core.Entity
{
    public class TipoUsuarios
    {
        public int  Id{ get; set; }
        public string TipoUsuario { get; set; }
        public List<Usuarios> Usuarios { get; set; }
    }
}
