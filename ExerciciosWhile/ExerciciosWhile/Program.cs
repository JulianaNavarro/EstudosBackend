using System;
using System.Globalization;

namespace ExerciciosWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            //EXERCÍCIO 01
            Console.Write("Digite a senha: ");
            string senha = Console.ReadLine();

            while (senha != "2002")
            {
                Console.WriteLine("Senha Invalida");
                Console.Write("Digite a senha: ");
                senha = Console.ReadLine();
            }

            Console.WriteLine("Acesso Permitido");

            //EXERCÍCIO 02
            Console.Write("Digite o primeiro número: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            int y = int.Parse(Console.ReadLine());

            while (x != 0 && y != 0)
            {
                if (x > 0 && y > 0)
                {
                    Console.WriteLine("primeiro");
                }
                else if (x < 0 && y > 0)
                {
                    Console.WriteLine("segundo");
                }
                else if (x < 0 && y < 0)
                {
                    Console.WriteLine("terceiro");
                }
                else
                {
                    Console.WriteLine("quarto");
                }
                Console.Write("Digite o primeiro número: ");
                x = int.Parse(Console.ReadLine());
                Console.Write("Digite o segundo número: ");
                y = int.Parse(Console.ReadLine());
            }

            //EXERCÍCIO 03
            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;

            Console.Write("Digite o código: ");
            int codigo = int.Parse(Console.ReadLine());

            while (codigo != 4)
            {
                if (codigo == 1)
                {
                    alcool = alcool + 1;
                }
                else if (codigo == 2)
                {
                    gasolina = gasolina + 1;
                }
                else if (codigo == 3)
                {
                    diesel = diesel + 1;
                }
                Console.Write("Digite o código: ");
                codigo = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine("Alcool: " + alcool);
            Console.WriteLine("Gasolina: " + gasolina);
            Console.WriteLine("Diesel: " + diesel);
        } 
    }
}
