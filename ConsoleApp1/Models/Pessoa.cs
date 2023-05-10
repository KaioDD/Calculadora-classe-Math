using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    internal class Pessoa
    {
        public Pessoa(string nome, string sobreNome, int idade) 
        {
            Nome = nome; SobreNome = sobreNome; Idade = idade;
           
        }

        public string Nome { get; set; }

        public string SobreNome { get; set; }

        public int Idade { get; set; }
       
    
        public void apresentar()
        {
            Console.WriteLine($"Olá ne chamo {Nome} {SobreNome}, e tenho {Idade} anos!");
        }
    }
}
