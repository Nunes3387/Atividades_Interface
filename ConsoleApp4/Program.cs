using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp4
{
    internal class Program 
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa();
            pessoa.Nome = "Robenilton Juarez";
            pessoa.Idade = 25;
            pessoa.Endereco = "Rua dos Campos Elisios";

            int idade = pessoa.ObterIdade();
            Console.WriteLine("Sua Idade é: "+idade);

            Console.ReadKey();
        }
    }
}
