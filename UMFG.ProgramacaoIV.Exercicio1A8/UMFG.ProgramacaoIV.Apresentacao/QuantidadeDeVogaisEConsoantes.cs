using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMFG.ProgramacaoIV.Apresentacao
{
    internal class QuantidadeDeVogaisEConsoantes
    {
        private string NomeUsuario { get; set; }
        private int Contador { get; set; }
        private char Vogal { get; set; }

        public int ContarVogais (string nome) 
        {
            NomeUsuario = nome;
            Contador = 0;

            NomeUsuario = string.IsNullOrWhiteSpace(nome)
                ? throw new ArgumentNullException(nameof(nome)) : nome;

            for (int i = 0; i < NomeUsuario.Length; i++) 
            {
                Vogal = NomeUsuario.ToLower()[i];
                if ("aeiou".Contains(Vogal)) 
                {
                    Contador++;
                }
            }
            Console.WriteLine("+----------------------------------------------+");
            Console.WriteLine("| Quantidade Vogais: " + Contador);
            return Contador;
        }

        public int ContarConsantes(string nome)
        {
            NomeUsuario = nome;
            Contador = 0;

            NomeUsuario = string.IsNullOrWhiteSpace(nome)
                ? throw new ArgumentNullException(nameof(nome)) : nome;

            for (int i = 0; i < NomeUsuario.Length; i++)
            {
                Vogal = NomeUsuario.ToLower()[i];
                if ("bcdfghjklmnpqrstvwxyz".Contains(Vogal))
                {
                    Contador++;
                }
            }
            Console.WriteLine("+----------------------------------------------+");
            Console.WriteLine("| Quantidade Consoantes: " + Contador);
            return Contador;
        }
    }
}
