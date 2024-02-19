using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using UMFG.ProgramacaoIV.Dominio.Extensoes;

namespace UMFG.ProgramacaoIV.Dominio.Entidades
{
    public sealed class Livro : AbstractEntidade
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public decimal Valor { get; set; }

        public Livro(string tituloLivro, string autorLivro, decimal valorLivro, string usuarioAlteracao, string usuarioCadastro)
            : base(usuarioAlteracao, usuarioCadastro)
        {
            Titulo = string.IsNullOrWhiteSpace(tituloLivro)
                ? throw new ArgumentNullException(nameof(tituloLivro)) : tituloLivro;

            Autor = string.IsNullOrWhiteSpace(autorLivro)
                ? throw new ArgumentNullException(nameof(autorLivro)) : autorLivro;

            Valor = valorLivro;

            Console.WriteLine("+-----------------------------------+");
            Console.WriteLine("|          Livro Cadastrado         |");
        }

        public override string ToString()
            => $"| > Titulo: {Titulo} | Autor: {Autor} | Valor: R$ {Valor} | Data cadastro: {DataCadastro.ToString("dd/MM/yyyy")} |";

    }
}