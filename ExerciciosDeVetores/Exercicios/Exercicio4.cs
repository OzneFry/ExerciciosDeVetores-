using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrabalhoEsteban;

namespace TrabalhoEsteban.Exercícios
{
    public class Exercicio4 : IExercicio
    {
        public void Executar()
        {
            Console.Write("Quantos números você deseja inserir? ");
            int n = int.Parse(Console.ReadLine());

            double[] vetor = new double[n];
            double soma = 0;

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Digite o {i + 1}º número: ");
                vetor[i] = double.Parse(Console.ReadLine());
                soma += vetor[i];
            }

            double media = soma / n;
            Console.WriteLine($"Média: {media}");

            Console.Write("Elementos abaixo da média: ");
            for (int i = 0; i < n; i++)
            {
                if (vetor[i] < media)
                {
                    Console.Write(vetor[i] + " ");
                }
            }
            Console.WriteLine();
            Console.WriteLine("Tecle enter para fechar ...");
            Console.ReadLine();
        }
    }
}
