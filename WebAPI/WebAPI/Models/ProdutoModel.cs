using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class ProdutoModel
    {
        public ProdutoModel(string[] itens)
        {
            IdProduto = int.Parse(itens[0]);
            Descricao = itens[1];
            PrecoCusto = decimal.Parse(itens[2]);
            PrecoVenda = decimal.Parse(itens[3]);
            Ncm = itens[4];
            Referencia = itens[5];
            DataCadastro = DateTime.Parse(itens[6]);
        }

        public ProdutoModel()
        {

        }

        public int IdProduto { get; set; }

        public int IdUsuario { get; set; }

        public string Descricao { get; set; }

        public decimal PrecoCusto { get; set; }

        public decimal PrecoVenda { get; set; }

        public string Ncm { get; set; }

        public string Referencia { get; set; }

        public DateTime DataCadastro { get; set; }
    }
}
