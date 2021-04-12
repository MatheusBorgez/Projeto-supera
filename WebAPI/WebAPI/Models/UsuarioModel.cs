using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class UsuarioModel
    {
        public UsuarioModel(int id, string username, string senha)
        {
            Id = id;
            Username = username;
            Senha = senha;
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; }

        public string Username { get; set; }
        
        public string Senha { get; set; }     
    }
}
