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

        public Calculadora(double n1, double n2, string operacao)
        {
            this.n1 = n1;
            this.n2 = n2;
            this.operacao = operacao;
        }
        public double RealizaOperacao()
        {
            double resposta = 0.0;
            switch (operacao)
            {
                case "+": resposta = n1 + n2; break;
                case "-": resposta = n1 - n2; break;
                case "*": resposta = n1 * n2; break;
                case "/": resposta = n1 / n2; break;
                default: break;
            }
            return resposta;
        }

    }
    
}
