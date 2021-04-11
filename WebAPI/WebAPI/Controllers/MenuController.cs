using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebAPI.Models;
using WebAPI.Processos;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MenuController : ControllerBase
    {
        [HttpPost]
        public void ImportArquivo(string caminhoArquivo)
        {
            var produtos = new ProcessoArquivos().ImporteProdutos(caminhoArquivo);
        }
    }
}
