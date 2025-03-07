using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrabalhoEsteban;

namespace TrabalhoEsteban.Exercícios
{
    public class Exercicio8 : IExercicio
    {
        public void Executar()
        {
            Console.Write("Quantas pessoas você deseja inserir? ");
            int n = int.Parse(Console.ReadLine());

            double[] alturas = new double[n];
            char[] sexos = new char[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Digite a altura da {i + 1}ª pessoa: ");
                alturas[i] = double.Parse(Console.ReadLine());

                Console.Write($"Digite o sexo da {i + 1}ª pessoa (M/F): ");
                sexos[i] = char.Parse(Console.ReadLine());
            }

            double menorAltura = alturas[0];
            double maiorAltura = alturas[0];
            double somaAlturasMulheres = 0;
            int quantidadeMulheres = 0;
            int quantidadeHomens = 0;

            for (int i = 0; i < n; i++)
            {
                if (alturas[i] < menorAltura)
                {
                    menorAltura = alturas[i];
                }

                if (alturas[i] > maiorAltura)
                {
                    maiorAltura = alturas[i];
                }

                if (sexos[i] == 'F' || sexos[i] == 'f')
                {
                    somaAlturasMulheres += alturas[i];
                    quantidadeMulheres++;
                }
                else
                {
                    quantidadeHomens++;
                }
            }

            double mediaAlturasMulheres = somaAlturasMulheres / quantidadeMulheres;

            Console.WriteLine($"Menor altura: {menorAltura}");
            Console.WriteLine($"Maior altura: {maiorAltura}");
            Console.WriteLine($"Média das alturas das mulheres: {mediaAlturasMulheres}");
            Console.WriteLine($"Número de homens: {quantidadeHomens}");
            Console.WriteLine("Tecle enter para fechar ...");
            Console.ReadLine();
        }
    }
}
