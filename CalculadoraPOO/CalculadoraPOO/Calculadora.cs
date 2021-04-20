using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraPOO
{
    class Calculadora
    {
        public double n1;
        public double n2;
        public string operacao;
        public string historico;

        public Calculadora(double n1, double n2, string operacao, string historico)
        {
            this.n1 = n1;
            this.n2 = n2;
            this.operacao = operacao;
            this.historico = historico;
        }
        public double RealizaOperacao()
        {
            double resposta = 0.0;
            switch (operacao)
            {
                case "1": resposta = n1 + n2; break;
                case "2": resposta = n1 - n2; break;
                case "3": resposta = n1 * n2; break;
                case "4": resposta = n1 / n2; break;
                default: break;
            }
            return resposta;
        }
        public string AdicionaHistorico(string opcao, double primeiroNumero, double segundoNumero)
        {
            string historico;
            switch (opcao)
            {
                case "1":
                    historico = ($"{primeiroNumero} + {segundoNumero} = {primeiroNumero + segundoNumero} \n");
                    break;
                case "2":
                    historico = ($"{primeiroNumero} - {segundoNumero} = {primeiroNumero - segundoNumero} \n");
                    break;
                case "3":
                    historico = ($"{primeiroNumero} * {segundoNumero} = {primeiroNumero * segundoNumero} \n");
                    break;
                case "4":
                    historico = ($"{primeiroNumero} / {segundoNumero} = {primeiroNumero / segundoNumero} \n");
                    break;
                default: //teoricamente, nunca deve cair aqui por verificação anterior a chamada da função
                    { historico = ""; Console.WriteLine("Opcao Invalida"); break; }
            }

            return historico;
        }
    }
    
}
