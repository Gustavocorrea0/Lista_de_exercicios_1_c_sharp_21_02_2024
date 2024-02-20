using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UMFG.ProgramacaoIV.Dominio.Entities;

namespace UMFG.ProgramacaoIV.Dominio.Entities
{
    public sealed class Aluno : AbstractEntitie
    {
        public string NomeAluno { get; set; }

        public int RA { get; set; }

        public double NotaProva { get; set; }

        public double NotaTrabalho { get; set; }

        public int Faltas { get; set; }

        public double Media;

        public double Aulas = 25.0;

        public Aluno(string nomeAluno, int raAluno, string usuarioAlteracao, string usuarioCadastro)
            : base(usuarioAlteracao, usuarioCadastro)
        {
            NomeAluno = string.IsNullOrWhiteSpace(nomeAluno)
                ? throw new ArgumentNullException(nameof(nomeAluno)) : nomeAluno;

            RA = raAluno;
            Console.WriteLine("+--------------------------------+");
            Console.WriteLine("|        Aluno Cadastrado        |");
        }

        public double CalcularMediaAluno() 
        {
            Media = (NotaProva * 0.7) + (NotaTrabalho * 0.3);
            Media = Math.Round(Media, 2);
            return Media;
        }

        public double CalcularFrequenciaAluno() 
        {
            return (25 - Faltas) / Aulas * 100;
        }

        public string ValidarSituacaoAluno() 
        {
            if (CalcularMediaAluno() >= 7 && CalcularFrequenciaAluno() >= 75) 
            {
                return ("Aprovado");
            } 
            else 
            {
                return ("Reprovado");
            }
        }

        public override string ToString()
            => $"| > Aluno: {NomeAluno} | RA: {RA} | Nota de Prova: {NotaProva} " +
            $"| Nota de Trabalho: {NotaTrabalho} | Média: {CalcularMediaAluno()}" +
            $"| Faltas: {Faltas} | Frequencia: {CalcularFrequenciaAluno()}% | Situação: {ValidarSituacaoAluno()}";



    }
}
