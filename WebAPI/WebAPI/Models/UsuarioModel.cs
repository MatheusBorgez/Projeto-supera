﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class UsuarioModel
    {
        public int Id { get; }

        public string Username { get; set; }
        
        public string Senha { get; set; }     
    }
}
