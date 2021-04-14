using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebAPI.Models;
using WebAPI.Processos;
using WebAPI.Repository;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MenuController : ControllerBase
    {

        public IRepositorioProdutos _repositorioProdutos;

        public MenuController(IRepositorioProdutos repositorioProdutos)
        {
            _repositorioProdutos = repositorioProdutos;
        }

        [HttpPost]
        public IActionResult ImporteArquivo(string caminhoArquivo)
        {
            var response = new ProcessoArquivos().ImporteProdutos(caminhoArquivo);

            return new ObjectResult(response);
        }
    }
}
