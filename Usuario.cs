using System;
using System.IO;

namespace Orkurtir {
    public class Usuario {
        public string Nome { get; private set;}
        public string Username { get; private set; }
        public string Senha { get; private set; }
        public string[] Interesses{ get; private set; }
        public int[] IdPaginas{ get; private set; }
        public int[] IdPosts{ get; private set; }
        
        public Usuario(string nome, string username, string senha){
            this.Nome = nome;
            this.Username = username;
            this.Senha = senha;
        }
        
        public void SetSenha(string senha){
            this.Senha = senha;
        }
    }
}