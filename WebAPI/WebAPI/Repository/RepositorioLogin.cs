using System;
using WebAPI.Models;

namespace WebAPI.Repository
{
    public class RepositorioLogin : IRepositorioLogin
    {
        public void AltereSenhaUsuario(UsuarioModel usuario, string novaSenha)
        {
            throw new NotImplementedException();
        }

        public void InsiraUsuario(UsuarioModel usuario)
        {
            throw new NotImplementedException();
        }

        public UsuarioModel ObtenhaUsuario(string usuario)
        {
            using var cmd = DbHelper.DbConnection().CreateCommand();

            cmd.CommandText = $"SELECT id, usuario, senha FROM USUARIOS WHERE usuario = '{usuario}'";

            try
            {
                using var dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    return new UsuarioModel(dr.GetInt32(0), dr.GetString(1), dr.GetString(2));
                }

                return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
