using Microsoft.AspNetCore.Mvc;
using WebAPI.Models;
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
            var response =_repositorioLogin.AutentiqueUsuario(usuario.Username, usuario.Senha);

            if(response == null)
            {
                return NotFound(usuario);
            }

            return new ObjectResult(response);
        }
    }
}
