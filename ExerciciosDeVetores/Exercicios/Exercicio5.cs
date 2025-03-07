using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrabalhoEsteban;

namespace TrabalhoEsteban.Exercícios
{
    public class Exercicio5 : IExercicio
    {
        public void Executar()
        {
            Console.Write("Quantos números você deseja inserir? ");
            int n = int.Parse(Console.ReadLine());

            int[] vetor = new int[n];
            int somaPares = 0;
            int quantidadePares = 0;

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Digite o {i + 1}º número: ");
                vetor[i] = int.Parse(Console.ReadLine());

                if (vetor[i] % 2 == 0)
                {
                    somaPares += vetor[i];
                    quantidadePares++;
                }
            }

            if (quantidadePares > 0)
            {
                double mediaPares = (double)somaPares / quantidadePares;
                Console.WriteLine($"Média dos números pares: {mediaPares}");
            }
            else
            {
                Console.WriteLine("Não há números pares para calcular a média.");
                Console.WriteLine("Tecle enter para fechar ...");
                Console.ReadLine();
            }
        }
    }
}
