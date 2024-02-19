using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UMFG.ProgramacaoIV.Dominio.Entidades;

namespace UMFG.ProgramacaoIV.Dominio.Interfaces
{
    public interface ILivroServico
    {
        void AdicionarLivro(Livro livro);
        IEnumerable<Livro> obterLivros();
    }
}
