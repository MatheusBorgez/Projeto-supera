using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models;

namespace WebAPI.Repository
{
    public interface IRepositorioLogin
    {
        public UsuarioModel AutentiqueUsuario(string usuario, string senha);
        public UsuarioModel ObtenhaUsuario(string usuario);
        public void InsiraUsuario(UsuarioModel usuario);
        public void AltereSenhaUsuario(UsuarioModel usuario, string novaSenha);
    }
}
