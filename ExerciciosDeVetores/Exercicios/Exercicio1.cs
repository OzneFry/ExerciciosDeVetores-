using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrabalhoEsteban.Exercícios
{
    public class Exercicio1 : IExercicio
    {
        public void Executar()
        {
            Console.Write("Quantos números você deseja inserir? ");
            int n = int.Parse(Console.ReadLine());
            double[] vetor = new double[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Digite o {i + 1}º número: ");
                vetor[i] = double.Parse(Console.ReadLine());
            }

            double maior = vetor[0];
            int posicao = 0;

            for (int i = 1; i < n; i++)
            {
                if (vetor[i] > maior)
                {
                    maior = vetor[i];
                    posicao = i;
                }
            }

            Console.WriteLine($"O maior número é {maior} e está na posição {posicao}.");
            Console.WriteLine("Tecle enter para fechar ...");
            Console.ReadLine();
        }
    }
}
