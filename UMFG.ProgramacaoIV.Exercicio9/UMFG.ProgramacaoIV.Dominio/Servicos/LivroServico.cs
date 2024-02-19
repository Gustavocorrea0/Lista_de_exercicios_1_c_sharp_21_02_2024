using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UMFG.ProgramacaoIV.Dominio.Entidades;
using UMFG.ProgramacaoIV.Dominio.Interfaces;

namespace UMFG.ProgramacaoIV.Dominio.Servicos
{
    public class LivroServico : ILivroServico
    {
        private readonly List<Livro> _livros = new List<Livro>();

        public void AdicionarLivro(Livro livro) => _livros.Add(livro);

        public IEnumerable<Livro> obterLivros() => _livros;
    }
}
