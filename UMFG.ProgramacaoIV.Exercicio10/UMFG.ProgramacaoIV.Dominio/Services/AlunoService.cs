using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UMFG.ProgramacaoIV.Dominio.Entities;
using UMFG.ProgramacaoIV.Dominio.Interfaces;

namespace UMFG.ProgramacaoIV.Dominio.Services
{
    public class AlunoService : IAlunoService
    {

        private readonly List<Aluno> _alunos = new List<Aluno>();

        public void adicionarAluno(Aluno aluno) => _alunos.Add(aluno);

        public void adicionarNota(int ra, double notaProva, double notaTrabalho) 
        {
            Aluno aluno = _alunos.Find(a => a.RA == ra);

            if (aluno != null)
            {
                aluno.NotaTrabalho = notaTrabalho;
                aluno.NotaProva = notaProva;
                Console.WriteLine("+--------------------------------+");
                Console.WriteLine("|          Nota lançada          |");
            }
            else 
            {
                Console.WriteLine("+--------------------------------+");
                Console.WriteLine("|       Aluno não encontrado     |");
            }
        }

        public void adicionarFaltas(int ra, int numeroFaltas)
        {
            Aluno aluno = _alunos.Find(a => a.RA == ra);

            if (aluno != null)
            {
                aluno.Faltas = numeroFaltas;
                Console.WriteLine("+--------------------------------+");
                Console.WriteLine("|       Falta(s) Lançada(s)      |");
            }
            else
            {
                Console.WriteLine("+--------------------------------+");
                Console.WriteLine("|       Aluno não encontrado     |");
            }
        }

        public IEnumerable<Aluno> obterAlunos() => _alunos;

        
    }
}
