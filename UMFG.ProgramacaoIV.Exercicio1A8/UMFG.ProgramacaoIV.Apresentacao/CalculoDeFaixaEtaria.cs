using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMFG.ProgramacaoIV.Apresentacao
{
    internal class CalculoDeFaixaEtaria
    {
        private DateTime DataAtual { get; set; }
        private DateTime DataNascimentoUsuario { get; set; }
        private string NomeUsuario { get; set; }
        private int Idade { get; set; }

        public void CalcularFaixaEtaria(DateTime dataNascimentoUsuario, string nome) 
        {
            DataNascimentoUsuario = dataNascimentoUsuario;
            DataAtual = DateTime.Today;
            NomeUsuario = nome;

            NomeUsuario = string.IsNullOrWhiteSpace(nome)
                ? throw new ArgumentNullException(nameof(nome)) : nome;

            Console.WriteLine("+----------------------------------------------+");

            Idade = DataAtual.Year - DataNascimentoUsuario.Year;


            if (DataAtual.Year < DataNascimentoUsuario.Year)
            {
                Console.WriteLine("|           Ano de Nascimento Inválido         |");
            }
            else if (Idade <= 19)
            {
                Console.WriteLine("| Nome: " + NomeUsuario + " | Faixa Etaria: Jovem");
            }
            else if (Idade >= 20 && Idade <= 59)
            {
                Console.WriteLine("| Nome: " + NomeUsuario + " | Faixa Etaria : Adulto");
            } 
            else
            {
                Console.WriteLine("| Nome: " + NomeUsuario + " | Faixa Etaria : Idoso");
            }
            
        }

    }
}
