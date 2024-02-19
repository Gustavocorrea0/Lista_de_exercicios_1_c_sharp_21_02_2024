using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UMFG.ProgramacaoIV.Dominio.Entities;

namespace UMFG.ProgramacaoIV.Dominio.Interfaces
{
    public interface IAlunoService
    {
        void adicionarAluno(Aluno aluno);
        IEnumerable<Aluno> obterAlunos();
    }
}
