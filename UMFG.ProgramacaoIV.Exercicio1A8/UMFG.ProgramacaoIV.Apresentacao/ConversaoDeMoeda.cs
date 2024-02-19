using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMFG.ProgramacaoIV.Apresentacao
{
    internal class ConversaoDeMoeda
    {
        public double ValorReal { get; set; }
        public double ValorDolar { get; set; }
        public double ValorUsuario { get; set; }
        public double ValorCovertido { get; set; }

        public void ConverterRealParaDolar(double valorUsuario) 
        {
            ValorDolar = 0.193259;
            ValorUsuario = valorUsuario;
            ValorCovertido = ValorUsuario * ValorDolar;
            ValorCovertido = Math.Round(ValorCovertido, 2);
            Console.WriteLine("+----------------------------------------------+");
            Console.WriteLine("| Conversão = US$" + ValorCovertido);
        }

        public void ConverterDolarParaReal(double valorUsuario)
        {
            ValorReal = 5.22;
            ValorUsuario = valorUsuario;
            ValorCovertido = ValorUsuario * ValorReal;
            ValorCovertido = Math.Round(ValorCovertido, 2);
            Console.WriteLine("+----------------------------------------------+");
            Console.WriteLine("| Conversão = R$" + ValorCovertido);
        }
    }
}
