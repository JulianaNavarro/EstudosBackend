using System;
using System.Globalization;

namespace ExerciciosCondicional
{
    class Program
    {
        static void Main(string[] args)
        {

            //EXERCÍCIO 01
            Console.WriteLine("Digite um número inteiro:");
            int n1 = int.Parse(Console.ReadLine());

            if (n1 < 0)
            {
                Console.WriteLine("NEGATIVO");
            }

            else
            {
                Console.WriteLine("NÃO NEGATIVO");
            }

            //EXERCÍCIO 02
            Console.WriteLine("Digite um número inteiro:");
            int x1 = int.Parse(Console.ReadLine());

            if (x1 % 2 == 0)
            {
                Console.WriteLine("PAR");
            }

            else
            {
                Console.WriteLine("IMPAR");
            }

            // EXERCÍCIO 03
            Console.WriteLine("Digite dois números inteiros");
            string[] numeros = Console.ReadLine().Split(' ');

            int y1 = int.Parse(numeros[0]);
            int y2 = int.Parse(numeros[0]);

            if (y1 % y2 == 0 || y2 % y1 == 0)
            {
                Console.WriteLine("Sao Multiplos");
            }

            else
            {
                Console.WriteLine("Nao sao Multiplos");
            }

            // EXERCÍCIO 04
            Console.WriteLine("Digite Hora Inicial e Hora Final");
            string[] valores = Console.ReadLine().Split(' ');
            int horaInicial = int.Parse(valores[0]);
            int horaFinal = int.Parse(valores[1]);

            int duracao = 0;
            if (horaInicial < horaFinal)
            {
                duracao = horaFinal - horaInicial;
            }
            else
            {
                duracao = 24 - horaInicial + horaFinal;
            }

            Console.WriteLine("O JOGO DUROU " + duracao + " HORA(S)");

            // EXERCÍCIO 05
            Console.WriteLine("Digite o código e a quantidade do item");
            string[] dados = Console.ReadLine().Split();
            int cod = int.Parse(dados[0]);
            int qnt = int.Parse(dados[1]);

            double total = 0.00;
            if (cod == 1)
            {
                total = 4 * qnt;
            }
            else if (cod == 2)
            {
                total = 4.5 * qnt;
            }
            else if (cod == 3)
            {
                total = 5 * qnt;
            }
            else if (cod == 4)
            {
                total = 2 * qnt;
            }
            else
            {
                total = 1.5 * qnt;
            }

            Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));

            // EXERCÍCIO 06
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (valor >= 0 && valor <= 25)
            {
                Console.WriteLine("Intervalo [0,25]");
            }
            else if (valor > 25 && valor <= 50)
            {
                Console.WriteLine("Intervalo [25,50]");
            }
            else if (valor > 50 && valor <= 75)
            {
                Console.WriteLine("Intervalo [50,75]");
            }
            else if (valor > 75 && valor <= 100)
            {
                Console.WriteLine("Intervalo [75,100]");
            }
            else
            {
                Console.WriteLine("Fora de Intervalo");
            }

            // EXERCÍCIO 07
            double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (x == 0.0 && y == 0.0)
            {
                Console.WriteLine("Origem");
            }
            else if (x == 0.0)
            {
                Console.WriteLine("Eixo Y");
            }
            else if (y == 0.0)
            {
                Console.WriteLine("Eixo X");
            }
            else if (x > 0.0 && y > 0.0)
            {
                Console.WriteLine("Q1");
            }
            else if (x < 0.0 && y > 0.0)
            {
                Console.WriteLine("Q2");
            }
            else if (x < 0.0 && y < 0.0)
            {
                Console.WriteLine("Q3");
            }
            else
            {
                Console.WriteLine("Q4");
            }

            // EXERCÍCIO 08
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double taxa = 0.00;

            if (salario <= 2000)
            {
                taxa = 0.0;
            }
            else if (salario <= 3000)
            {
                taxa = (salario - 2000) * 0.08;
            }
            else if (salario <= 4500)
            {
                taxa = (salario - 3000) * 0.18 + (1000 * 0.08);
            }
            else
            {
                taxa = (salario - 4500) * 0.28 + (1500 * 0.18) + (1000 * 0.08);
            }

            if (taxa == 0.0)
            {
                Console.WriteLine("Isento");
            }
            else
            {
                Console.WriteLine("R$ " + taxa.ToString("F2", CultureInfo.InvariantCulture));
            }
            
        }
    }
}
