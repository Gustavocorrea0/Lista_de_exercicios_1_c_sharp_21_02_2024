using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMFG.ProgramacaoIV.Dominio.Entities
{
    public sealed class Aluno : AbstractEntitie
    {
        public string NomeAluno { get; set; }
        public int RA { get; set; }
        public double NotaProva { get; set; }
        public double NotaTrabalho { get; set; }
        public int Faltas { get; set; }
        public string Situacao { get; set; }

        public Aluno(string nomeAluno, int raAluno, string usuarioAlteracao, string usuarioCadastro) 
            : base(usuarioAlteracao, usuarioCadastro)
        {
            NomeAluno = string.IsNullOrWhiteSpace(nomeAluno)
                ? throw new ArgumentNullException(nameof(nomeAluno)) : nomeAluno;
            
            RA = raAluno;

            Console.WriteLine("|          Aluno Cadastrado         |");
        }




    }
}
