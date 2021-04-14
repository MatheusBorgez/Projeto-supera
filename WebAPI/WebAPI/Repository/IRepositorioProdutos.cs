using System.Collections.Generic;
using WebAPI.Models;

namespace WebAPI.Repository
{
    public interface IRepositorioProdutos
    {
        public void InsiraProdutos(List<ProdutoModel> produtos);
        public void RemovaProdutosExportados(IEnumerable<int> idsProdutos, int idUsuario);
        public void EditeProduto(ProdutoModel produto);
        public List<ProdutoModel> ObtenhaProdutos(int idUsuario);
    }
}
