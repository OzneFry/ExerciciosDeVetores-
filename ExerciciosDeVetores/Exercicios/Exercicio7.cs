using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using TrabalhoEsteban;

namespace TrabalhoEsteban.Exercícios
{
    public class Exercicio7 : IExercicio
    {
        public void Executar()
        {
            Console.Write("Quantos alunos você deseja inserir? ");
            int n = int.Parse(Console.ReadLine());

            string[] nomes = new string[n];
            double[] notas1 = new double[n];
            double[] notas2 = new double[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Digite o nome do {i + 1}º aluno: ");
                nomes[i] = Console.ReadLine();

                Console.Write($"Digite a nota do 1º semestre de {nomes[i]}: ");
                notas1[i] = double.Parse(Console.ReadLine());

                Console.Write($"Digite a nota do 2º semestre de {nomes[i]}: ");
                notas2[i] = double.Parse(Console.ReadLine());
            }

            Console.WriteLine("Alunos aprovados:");
            for (int i = 0; i < n; i++)
            {
                double media = (notas1[i] + notas2[i]) / 2;
                if (media >= 6.0)
                {
                    Console.WriteLine(nomes[i]);
                }
                Console.WriteLine("Tecle enter para fechar ...");
                Console.ReadLine();
            }
        }
    }
}
