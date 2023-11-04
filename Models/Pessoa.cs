using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploSimples.Models
{
  public class Pessoa
  {
    public string Nome { get; set; }
    public int Idade { get; set; }

    public void Apresentar()
    {
      Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos.");
    }

    public void Apresentar2(string nome)
    {
      Console.WriteLine($"Olá, {nome}, meu nome é {Nome} e tenho {Idade} anos" + 
      " e estou apresentando o método Apresentar2.");
    }

    public void Apresentar3(string nome, int idade)
    {
      Console.WriteLine($"Olá, {nome} de {idade} anos, meu nome é {Nome} e tenho {Idade} anos" + 
      "\n e estou apresentando o método Apresentar3.");
    }
  }
}