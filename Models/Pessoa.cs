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

    char sexo { get; set;}

    object obj { get; set; }

    bool verdade { get; set; }

    // Mais preciso para representar valores monetários
    decimal valor { get; set; }

    double valor2 { get; set; }

    float valor3 { get; set; }

    int valor4 { get; set; }

    long valor5 { get; set; }

    uint valor6 { get; set; }

    short valor7 { get; set; }

    ulong valor8 { get; set; }

    DateTime data { get; set; }

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