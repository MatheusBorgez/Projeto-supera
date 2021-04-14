using System;
using System.Collections.Generic;
using System.Linq;
using WebAPI.Models;

namespace WebAPI.Repository
{
    public class RepositorioProdutos : IRepositorioProdutos
    {
        public void EditeProduto(ProdutoModel produto)
        {
            using var cn = DbHelper.DbConnection();
            using var tx = cn.BeginTransaction();
            using var cmd = tx.Connection.CreateCommand();

            cmd.Transaction = tx;

            cmd.CommandText = $@"UPDATE PRODUTOS
                                 SET descricao = {produto.Descricao},
                                 valor_compra = {produto.PrecoCusto},
                                 valor_venda = {produto.PrecoVenda},
                                 ncm = {produto.Ncm},
                                 referencia = {produto.Referencia},
                                 data_cadastro = {produto.DataCadastro}
                                 WHERE id_usuario = {produto.IdUsuario} 
                                    AND id_produto = {produto.IdProduto}";

            cmd.ExecuteNonQuery();
            tx.Commit();
        }

        public void InsiraProdutos(List<ProdutoModel> produtos)
        {
            using var cn = DbHelper.DbConnection();
            using var tx = cn.BeginTransaction();
            using var cmd = tx.Connection.CreateCommand();

            cmd.Transaction = tx;

            cmd.CommandText = $@"INSERT INTO PRODUTOS (id_usuario, descricao, valor_compra, 
                                 valor_venda, ncm, referencia, data_cadastro) 
                                VALUES ({produtos.First().IdUsuario}, @descricao, @valor_compra, @valor_venda, 
                                        @ncm, @referencia, @data_cadastro)";
            cmd.Prepare();

            cmd.Parameters.Add("@descricao");
            cmd.Parameters.Add("@valor_compra");
            cmd.Parameters.Add("@valor_venda");
            cmd.Parameters.Add("@ncm");
            cmd.Parameters.Add("@referencia");
            cmd.Parameters.Add("@data_cadastro");


            foreach (var produto in produtos)
            {
                cmd.Parameters["@descricao"].Value = produto.Descricao;
                cmd.Parameters["@valor_compra"].Value = produto.PrecoCusto;
                cmd.Parameters["@valor_venda"].Value = produto.PrecoVenda;
                cmd.Parameters["@ncm"].Value = produto.Ncm;
                cmd.Parameters["@referencia"].Value = produto.Referencia;
                cmd.Parameters["@data_cadastro"].Value = produto.DataCadastro.ToUniversalTime();
                cmd.ExecuteNonQuery();
            }

            tx.Commit();
        }

        public List<ProdutoModel> ObtenhaProdutos(int idUsuario)
        {
            var produtos = new List<ProdutoModel>();

            using var cmd = DbHelper.DbConnection().CreateCommand();

            cmd.CommandText = @$"SELECT id, id_usuario, descricao, valor_compra, 
                                 valor_venda, ncm, referencia, data_cadastro 
                                 FROM produtos WHERE id_produto = {idUsuario}";

            using var dr = cmd.ExecuteReader();

            while(dr.Read())
            {                
                produtos.Add(new ProdutoModel
                {
                    IdProduto = dr.GetInt32(0),
                    IdUsuario = dr.GetInt32(1),
                    Descricao = dr.GetString(3),
                    PrecoCusto = dr.GetDecimal(4),
                    PrecoVenda = dr.GetDecimal(5),
                    Ncm = dr.GetString(6),
                    Referencia = dr.GetString(7),
                    DataCadastro = DateTime.Parse(dr.GetString(8)),
                });
            }

            return produtos;
        }

        public void RemovaProdutosExportados(IEnumerable<int> idsProdutos, int idUsuario)
        {
            using var cn = DbHelper.DbConnection();
            using var tx = cn.BeginTransaction();
            using var cmd = tx.Connection.CreateCommand();

            cmd.CommandText = $@"DELETE FROM PRODUTOS WHERE id_usuario = {idUsuario} AND id_produto = @id_produto";
            cmd.Transaction = tx;
            cmd.Prepare();

            cmd.Parameters.Add("@id_produto");

            foreach (var idProduto in idsProdutos)
            {
                cmd.Parameters["@id_produto"].Value = idProduto;
                cmd.ExecuteNonQuery();
            }

            tx.Commit();
        }
    }
}
