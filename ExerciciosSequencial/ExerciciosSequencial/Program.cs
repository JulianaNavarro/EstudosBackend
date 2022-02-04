using System;
using System.Globalization;

namespace ExerciciosSequencial
{
    class Program
    {
        static void Main(string[] args)
        {

            //EXERCÍCIO 01
            Console.WriteLine("Digite o Primeiro número para realizar a soma");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o Segundo número para realizar a soma");
            int n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("SOMA = " + (n1 + n2));

            //EXERCÍCIO 02
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double area = 3.14159 * Math.Pow(raio, 2);

            Console.WriteLine("A=" + area.ToString("F4", CultureInfo.InvariantCulture));

            //EXERCÍCIO 03
            int x1 = int.Parse(Console.ReadLine());
            int x2 = int.Parse(Console.ReadLine());
            int x3 = int.Parse(Console.ReadLine());
            int x4 = int.Parse(Console.ReadLine());

            int diferenca = x1 * x2 - x3 * x4;

            Console.WriteLine("DIFERENCA = " + diferenca);

            //EXERCÍCIO 04
            int cod = int.Parse(Console.ReadLine());
            double horas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double calcSal = horas * valor;

            Console.WriteLine("NUMBER = " + cod);
            Console.WriteLine("SALARY = U$ " + calcSal.ToString("F2", CultureInfo.InvariantCulture));

            //EXERCÍCIO 05
            string[] valores1 = Console.ReadLine().Split(' ');
            string[] valores2 = Console.ReadLine().Split(' ');

            int pecas1 = int.Parse(valores1[1]);
            double valor1 = double.Parse(valores1[2], CultureInfo.InvariantCulture);

            int pecas2 = int.Parse(valores2[1]);
            double valor2 = double.Parse(valores2[2], CultureInfo.InvariantCulture);

            double total = pecas1 * valor1 + pecas2 * valor2;

            Console.WriteLine("VALOR A PAGAR: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));

            //EXERCÍCIO 06
            string[] valores = Console.ReadLine().Split(' ');
            double A = double.Parse(valores[0], CultureInfo.InvariantCulture);
            double B = double.Parse(valores[1], CultureInfo.InvariantCulture);
            double C = double.Parse(valores[2], CultureInfo.InvariantCulture);

            double triangulo = (A * C) / 2.0;
            double circulo = 3.14159 * Math.Pow(C, 2);
            double trapezio = (A + B) * C / 2.0;
            double quadrado = B * B;
            double retangulo = A * B;

            Console.WriteLine("TRIANGULO: " + triangulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: " + circulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO: " + trapezio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: " + quadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO: " + retangulo.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
