// See https://aka.ms/new-console-template for more information
using ExemploSimples.Models;

Pessoa pessoa = new()
{
  Nome = "João",
  Idade = 30
};

pessoa.Apresentar();

pessoa.Nome = "Maria";
pessoa.Idade = 25;

pessoa.Apresentar();

pessoa.Apresentar2("José");

pessoa.Apresentar3("José", 40);