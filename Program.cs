using System;
using Aula_POO_Poliformismo.classes;

namespace Aula_POO_Poliformismo
{
    class Program
    {
        static void Main(string[] args)
        {
            MegaMen jogador = new MegaMen();
            Console.WriteLine($"Jogador 1 = {jogador.Correr()}");

            Zero jogador2 = new Zero();
            Console.WriteLine($"Jogador 2 = {jogador.Correr()}");
        }
    }
}
