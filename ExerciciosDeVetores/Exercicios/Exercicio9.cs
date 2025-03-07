using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using TrabalhoEsteban;

namespace TrabalhoEsteban.Exercícios
{
    public class Exercicio9 : IExercicio
    {
        public void Executar()
        {
            Console.Write("Quantas mercadorias você deseja inserir? ");
            int n = int.Parse(Console.ReadLine());

            string[] nomes = new string[n];
            double[] precosCompra = new double[n];
            double[] precosVenda = new double[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Digite o nome da {i + 1}ª mercadoria: ");
                nomes[i] = Console.ReadLine();

                Console.Write($"Digite o preço de compra de {nomes[i]}: ");
                precosCompra[i] = double.Parse(Console.ReadLine());

                Console.Write($"Digite o preço de venda de {nomes[i]}: ");
                precosVenda[i] = double.Parse(Console.ReadLine());
            }

            int lucroAbaixo10 = 0;
            int lucroEntre10e20 = 0;
            int lucroAcima20 = 0;
            double valorTotalCompra = 0;
            double valorTotalVenda = 0;

            for (int i = 0; i < n; i++)
            {
                double lucro = ((precosVenda[i] - precosCompra[i]) / precosCompra[i]) * 100;
                valorTotalCompra += precosCompra[i];
                valorTotalVenda += precosVenda[i];

                if (lucro < 10)
                {
                    lucroAbaixo10++;
                }
                else if (lucro >= 10 && lucro <= 20)
                {
                    lucroEntre10e20++;
                }
                else
                {
                    lucroAcima20++;
                }
            }

            double lucroTotal = valorTotalVenda - valorTotalCompra;

            Console.WriteLine($"Lucro abaixo de 10%: {lucroAbaixo10}");
            Console.WriteLine($"Lucro entre 10% e 20%: {lucroEntre10e20}");
            Console.WriteLine($"Lucro acima de 20%: {lucroAcima20}");
            Console.WriteLine($"Valor total de compra: {valorTotalCompra}");
            Console.WriteLine($"Valor total de venda: {valorTotalVenda}");
            Console.WriteLine($"Lucro total: {lucroTotal}");
            Console.WriteLine("Tecle enter para fechar ...");
            Console.ReadLine();
        }
    }
}
