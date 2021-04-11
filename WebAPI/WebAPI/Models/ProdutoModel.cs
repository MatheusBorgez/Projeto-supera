using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class ProdutoModel
    {

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
