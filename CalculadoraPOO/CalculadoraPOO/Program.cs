using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Digite o valor do primeiro numero");
                double n1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Digite o valor do segundo numero");
                double n2 = Convert.ToDouble(Console.ReadLine());
            
                Console.WriteLine("Digite a operação desejada(+, -, /, *)");
                string operacao = Console.ReadLine();

                if ((operacao != "+") && (operacao != "-") && (operacao != "*") && (operacao != "/"))
                {
                    Console.WriteLine("Operação inválida, tente novamente");
                    Console.ReadLine();
                    Console.Clear();
                }
                else
                {
                    Calculadora c = new Calculadora(n1, n2, operacao);
                    double resposta = c.RealizaOperacao();
                    Console.WriteLine(resposta);
                    Console.ReadLine();
                    Console.Clear();
                }
            }
            catch
            {
                Console.WriteLine("Número inválido, tente novamente");
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
