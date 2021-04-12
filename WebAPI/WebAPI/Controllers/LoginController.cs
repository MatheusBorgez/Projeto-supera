using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models;
using WebAPI.Processos;
using WebAPI.Repository;

namespace WebAPI.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class LoginController : Controller
    {
        private readonly IRepositorioLogin _repositorioLogin;

        public LoginController(IRepositorioLogin repositorioLogin)
        {
            _repositorioLogin = repositorioLogin;
        }

        [HttpPost]
        public IActionResult AutentiqueUsuario([FromBody] UsuarioModel usuario)
        {
            var reponse = new ProcessoLogin().AutentiqueUsuario(usuario.Username, usuario.Senha);

            if(reponse == null)
            {
                return NotFound(usuario);
            }

            return new ObjectResult(reponse);
        }
    }
}
