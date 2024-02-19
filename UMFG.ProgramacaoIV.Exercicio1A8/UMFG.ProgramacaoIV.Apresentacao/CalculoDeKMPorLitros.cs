using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMFG.ProgramacaoIV.Apresentacao
{
    internal class CalculoDeKMPorLitros
    {
        private double DistaciaPercorrida { set; get; }
        private double QuantidadeDeLitrosGastos { set; get; }
        private double MediaDeKMPorLitro { set; get; }

        public void CalcularMedia(double distaciaPercorrida, double quantidadeDeLitrosGastos) 
        {
            DistaciaPercorrida = distaciaPercorrida;
            QuantidadeDeLitrosGastos = quantidadeDeLitrosGastos;
            MediaDeKMPorLitro = distaciaPercorrida / quantidadeDeLitrosGastos;
            MediaDeKMPorLitro = Math.Round(MediaDeKMPorLitro, 2);
            Console.WriteLine("+----------------------------------------------+");
            Console.WriteLine("| A média é de " + MediaDeKMPorLitro + " KMs/Litro");
        }
    }
}
