using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrabalhoEsteban.Exercícios
{
    public class Exercicio2 : IExercicio
    {
        public void Executar()
        {
            Console.Write("Quantos números você deseja inserir? ");
            int n = int.Parse(Console.ReadLine());

            int[] vetor = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Digite o {i + 1}º número: ");
                vetor[i] = int.Parse(Console.ReadLine());
            }

            int quantidadePares = 0;
            Console.Write("Números pares: ");
            for (int i = 0; i < n; i++)
            {
                if (vetor[i] % 2 == 0)
                {
                    Console.Write(vetor[i] + " ");
                    quantidadePares++;
                }
            }

            Console.WriteLine($"\nQuantidade de números pares: {quantidadePares}");
            Console.WriteLine("Tecle enter para fechar ...");
            Console.ReadLine();
        }
    }
}
