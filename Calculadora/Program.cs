using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // o usuario vai escolher uma opcao
            Console.WriteLine("Qual operacao deseja fazer? ");
            Console.WriteLine("1 - Adicao");
            Console.WriteLine("2 - Subtracao");
            Console.WriteLine("3 - Multiplicacao");
            Console.WriteLine("4 - Divisao");

            int operacao = int.Parse(Console.ReadLine());

            // usuario digita os numeros
            Console.WriteLine("Digite o primeiro numero: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo numero: ");
            int num2 = int.Parse(Console.ReadLine());

            float resultado = 0;

            switch (operacao)
            {
                case 1:
                    {
                        resultado = Adicao(num1, num2);
                        break;
                    }
                case 2:
                    {
                        resultado = Subtracao(num1, num2);
                        break;
                    }
                case 3:
                    {
                        resultado = Multiplicacao(num1, num2);
                        break;
                    }
                case 4:
                    {
                        resultado = Divisao(num1, num2);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Opcao Invalida. Tente Novamente");
                        break;
                    }
            }

            Console.WriteLine("Resultado com os numeros {0} e {1} e: {2}", num1, num2, resultado);

            Console.ReadLine();

        }

        public static int Adicao(int number1, int number2)
        {
            int result = number1 + number2;
            return result;
        }

        public static int Subtracao(int number1, int number2)
        {
            int result = number1 - number2;
            return result;
        }

        public static int Multiplicacao(int number1, int number2)
        {
            int result = number1 * number2;
            return result;
        }

        public static float Divisao(int number1, int number2)
        {
            float result = (float)number1 / number2;
            return result;
        }
    }
}
