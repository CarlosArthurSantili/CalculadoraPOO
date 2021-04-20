using CalculadoraPOO;
using System;

namespace CalculadoraPOO
{
    class Program
    {
        //1) Somar dois números OK
        //2) Várias operações de soma OK
        //3) Várias operações de soma e subtração OK
        //4) Fazer as 4 operações aritméticas (soma, subtração, multiplicação, divisão) OK
        //5) Validar a opções do menu OK
        //B1) BUG: Não permitir divisão por zero OK
        //6) Mostrar histórico de operações OK
        //7) Implementar Classe Calculadora OK
        static void Main(string[] args)
        {
            double resultado = 0;
            string opcao = "";
            string historico = "";
            do
            {
                Console.WriteLine("Calculadora 1.7.1");
                Console.WriteLine("Histórico:");
                Console.WriteLine($"{historico}");
                Console.WriteLine("\n");
                MostrarMenuOpcoes();
                opcao = Console.ReadLine();

                if ((opcao == "s") || (opcao == "S"))
                {
                    break;
                }
                else if ((opcao == "1") || (opcao == "2") || (opcao == "3") || (opcao == "4"))
                {
                    try
                    {
                        Console.WriteLine("Digite o primeiro número:");
                        string strPrimeiroNumero = Console.ReadLine();
                        double primeiroNumero = Convert.ToDouble(strPrimeiroNumero);

                        Console.WriteLine("Digite o segundo número:");
                        string strSegundoNumero = Console.ReadLine();
                        double segundoNumero = Convert.ToDouble(strSegundoNumero);


                        if ((opcao == "4") && (segundoNumero == 0))
                        {
                            Console.WriteLine("Não foi possível realizar a operação divisão, pois não existe divisão por zero");
                            Console.ReadLine();
                            Console.Clear();
                        }
                        else
                        {
                            Calculadora c = new Calculadora(primeiroNumero, segundoNumero, opcao, historico);
                            resultado = c.RealizaOperacao();
                            historico += c.AdicionaHistorico(opcao, primeiroNumero, segundoNumero);
                            ExibirResultado(resultado);
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Erro: Digite um número válido");
                        Console.ReadLine();
                        Console.Clear();
                    }

                }
                else
                {
                    Console.WriteLine("Opção Inválida");
                    Console.ReadLine();
                    Console.Clear();
                }
            }
            while (!opcao.Equals("S", StringComparison.OrdinalIgnoreCase));

        }

        private static void MostrarMenuOpcoes()
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("Digite 1 para somar ");
            Console.WriteLine("Digite 2 para subtrair ");
            Console.WriteLine("Digite 3 para multiplicar ");
            Console.WriteLine("Digite 4 para divisão ");
            Console.WriteLine("Digite S para sair");
        }

        private static void ExibirResultado(double resultado)
        {
            Console.Write("Resultado: ");
            Console.WriteLine(resultado);
            Console.ReadLine();
            Console.Clear();
        }
    }
}
