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

        public IEnumerable<Aluno> obterAlunos() => _alunos;


    }
}
