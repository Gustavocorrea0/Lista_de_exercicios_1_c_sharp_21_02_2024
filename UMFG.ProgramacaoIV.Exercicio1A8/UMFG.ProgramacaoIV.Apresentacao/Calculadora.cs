using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMFG.ProgramacaoIV.Apresentacao
{
    internal class Calculadora
    {
        private double PrimeroValor { set; get; }
        private double SegundoValor { set; get; }
        private double Resultado { set; get; }
        private string TipoConta { set; get; }

        public void Somar(double valorUm, double valorDois) 
        {
            PrimeroValor = valorUm;
            SegundoValor = valorDois;
            Resultado = PrimeroValor + SegundoValor;
            Console.WriteLine("+----------------------------------------------+");
            Console.WriteLine("| > Resultado = " + Resultado);
        }

        public void Subtrair(double valorUm, double valorDois)
        {
            PrimeroValor = valorUm;
            SegundoValor = valorDois;
            Resultado = PrimeroValor - SegundoValor;
            Console.WriteLine("+----------------------------------------------+");
            Console.WriteLine("| > Resultado = " + Resultado);
        }

        public void Dividir(double valorUm, double valorDois)
        {
            PrimeroValor = valorUm;
            SegundoValor = valorDois;
            Resultado = PrimeroValor / SegundoValor;
            Console.WriteLine("+----------------------------------------------+");
            Console.WriteLine("| > Resultado = " + Resultado);
        }

        public void Multiplicar(double valorUm, double valorDois)
        {
            PrimeroValor = valorUm;
            SegundoValor = valorDois;
            Resultado = PrimeroValor * SegundoValor;
            Console.WriteLine("+----------------------------------------------+");
            Console.WriteLine("| > Resultado = " + Resultado);
        }

        public void RestoDivisao(double valorUm, double valorDois)
        {
            PrimeroValor = valorUm;
            SegundoValor = valorDois;
            Resultado = PrimeroValor % SegundoValor;
            Console.WriteLine("+----------------------------------------------+");
            Console.WriteLine("| > Resultado = " + Resultado);
        }

    }
}
