using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrabalhoEsteban;

namespace TrabalhoEsteban.Exercícios
{
    public class Exercicio3 : IExercicio
    {
        public void Executar()
        {
            Console.Write("Quantos elementos terão os vetores? ");
            int n = int.Parse(Console.ReadLine());

            int[] vetorA = new int[n];
            int[] vetorB = new int[n];
            int[] vetorC = new int[n];

            Console.WriteLine("Digite os elementos do vetor A:");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Elemento {i + 1}: ");
                vetorA[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Digite os elementos do vetor B:");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Elemento {i + 1}: ");
                vetorB[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                vetorC[i] = vetorA[i] + vetorB[i];
            }

            Console.Write("Vetor C (soma de A e B): ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(vetorC[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Tecle enter para fechar ...");
            Console.ReadLine();
        }
    }
}
