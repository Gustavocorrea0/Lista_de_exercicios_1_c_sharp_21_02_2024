using UMFG.ProgramacaoIV.Dominio.Entidades;
using UMFG.ProgramacaoIV.Dominio.Interfaces;
using UMFG.ProgramacaoIV.Dominio.Servicos;

namespace UMFG.ProgramacaoIV.Apresentacao
{
    internal class Program
    {
        private const string C_USUARIO_PADRAO = "usuarioPadrao@umfg.edu.br";

        private static ILivroServico _servico = new LivroServico();

        static void Main(string[] args)
        {
            var opcao = 0;

            do
            {
                Console.WriteLine("+-----------------------------------+");
                Console.WriteLine("|                MENU               |");
                Console.WriteLine("+-----------------------------------+");
                Console.WriteLine("|        1 - Cadastrar Livro        |");
                Console.WriteLine("|        2 - Consultar Livros       |");
                Console.WriteLine("|        9 - Sair                   |");
                Console.WriteLine("+-----------------------------------+");
                Console.WriteLine("| > Opção desejada: ");
                int.TryParse(Console.ReadLine(), out opcao);

                switch (opcao)
                {
                    case 1:
                        CadastrarNovoLivro();
                        break;
                    case 2:
                        ListarLivros();
                        break;
                    case 9:
                        Console.WriteLine("+-----------------------------------+");
                        Console.WriteLine("|            Desligando...          |");
                        Console.WriteLine("+-----------------------------------+");
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("+-----------------------------------+");
                        Console.WriteLine("|           Opção Inválida          |");
                        break;
                }

            } while (opcao != 9);
        }

        public static void CadastrarNovoLivro()
        {
            try
            {
                Console.WriteLine("+-----------------------------------+");
                Console.WriteLine("|          Cadastrar Livro          |");
                Console.WriteLine("+-----------------------------------+");

                Console.WriteLine("| > Nome do Livro:");
                string nomeLivro = Console.ReadLine();

                Console.WriteLine("+-----------------------------------+");
                Console.WriteLine("| > Autor:");
                string autorLivro = Console.ReadLine();

                Console.WriteLine("+-----------------------------------+");
                Console.WriteLine("| > Valor:");
                var valorLivro = Console.ReadLine();

                decimal valorLivroConvertido = Convert.ToDecimal(valorLivro);

                Console.Clear();
                var novoLivro = new Livro(nomeLivro, autorLivro, valorLivroConvertido, C_USUARIO_PADRAO, C_USUARIO_PADRAO);
                _servico.AdicionarLivro(novoLivro);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void ListarLivros()
        {
            try
            {
                var sair = "c";
                do
                {
                    Console.WriteLine("+-----------------------------------+");
                    Console.WriteLine("|        Livros Cadastrados         |");
                    Console.WriteLine("+-----------------------------------+");
                    Console.WriteLine("|        L - Listar livros          |");
                    Console.WriteLine("|        V - Voltar ao Menu         |");
                    Console.WriteLine("+-----------------------------------+");
                    Console.WriteLine("| > Opção desejada:");
                    sair = Console.ReadLine();

                    switch (sair.ToLower())
                    {
                        case "l":
                            Console.Clear();
                            Console.WriteLine("+-----------------------------------+");
                            foreach (var item in _servico.obterLivros())
                            {
                                Console.WriteLine(item.ToString());
                            }
                            break;
                        default:
                            Console.Clear();
                            Console.WriteLine("+-----------------------------------+");
                            Console.WriteLine("|          Opção Inválida           |");
                            break;
                    }
                } while (sair.ToLower() != "v");
                Console.Clear();
            }
            catch (Exception ex)
            {
                Console.WriteLine("+-----------------------------------+");
                Console.WriteLine("|          Falha na busca           |");
            }
            finally
            {
                Console.WriteLine("+-----------------------------------+");
                Console.WriteLine("| Retornando para o menu principal! |");
            }
        }


    }
}