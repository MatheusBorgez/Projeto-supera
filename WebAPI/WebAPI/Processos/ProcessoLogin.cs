using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models;
using WebAPI.Repository;

namespace WebAPI.Processos
{
    public class ProcessoLogin
    {
        public UsuarioModel AutentiqueUsuario(string usuario, string senhaInserida)
        {
            var usuarioRecuperado = new RepositorioLogin().ObtenhaUsuario(usuario);

            if(usuarioRecuperado != null && usuarioRecuperado.Senha == senhaInserida)
            {
                return usuarioRecuperado;
            }

            return null;
        }
    }
}
