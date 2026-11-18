using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoGit.Model
{
    public class Cliente
    {

        public  Guid Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }

        public Cliente(string nome, int idade)
        {
            
            Nome = nome;
            Idade = idade;

        }



    }
}
