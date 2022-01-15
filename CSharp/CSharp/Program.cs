using System;
using CSharp;
using Interface;
using Enum;

namespace CSharp
{
    class Program
    {
        public static void Main (string[] args)
        {
            var person = (Pessoas)0;
            Pessoas person1 = Pessoas.Bento;//duas formas de chamar o enum

            Pessoa pessoa = new Pessoa();

            pessoa.Nome = "Jaque";
            pessoa.Estado = "Paraná";
            pessoa.Idade = 32;

            var pessoa2 = new Pessoa();

            pessoa2.Nome = "Alana";
            pessoa2.Estado= "Mato Grosso";
            pessoa2.Idade = 25;

            Animal animal = new Animal();
            animal.Nome = "Luna";
            animal.Especie = "cão";
            animal.Dono = "Ricardo";

        }

       
    }
       
}
