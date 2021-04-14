using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models;

namespace WebAPI.Processos
{
    public class ProcessoArquivos
    {
        public List<ProdutoModel> ImporteProdutos(string caminhoArquivo)
        {
            var arquivo = File.ReadAllText(caminhoArquivo);

            var linhasArquivo = arquivo.Split("\n").ToList();
            linhasArquivo.RemoveAt(0);

            return new List<ProdutoModel>(from linha in linhasArquivo
                                          let produtos = linha.Split('|')
                                          where produtos.Length == 7
                                          select new ProdutoModel(produtos));
        }
    }
}
