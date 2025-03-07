using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrabalhoEsteban;

namespace TrabalhoEsteban.Exercícios
{
    public class Exercicio6 : IExercicio
    {
        public void Executar()
        {
            Console.Write("Quantas pessoas você deseja inserir? ");
            int n = int.Parse(Console.ReadLine());

            string[] nomes = new string[n];
            int[] idades = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Digite o nome da {i + 1}ª pessoa: ");
                nomes[i] = Console.ReadLine();

                Console.Write($"Digite a idade de {nomes[i]}: ");
                idades[i] = int.Parse(Console.ReadLine());
            }

            int idadeMaisVelha = idades[0];
            string nomeMaisVelho = nomes[0];

            for (int i = 1; i < n; i++)
            {
                if (idades[i] > idadeMaisVelha)
                {
                    idadeMaisVelha = idades[i];
                    nomeMaisVelho = nomes[i];
                }
            }

            Console.WriteLine($"Pessoa mais velha: {nomeMaisVelho}");
            Console.WriteLine("Tecle enter para fechar ...");
            Console.ReadLine();
        }
    }
}
