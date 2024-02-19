namespace UMFG.ProgramacaoIV.Apresentacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        private static void Menu()
        {
            var opcao = 9;

            do
            {
                Console.WriteLine("+--------------------------------+");
                Console.WriteLine("|         Menu de Alunos         |");
                Console.WriteLine("+--------------------------------+");
                Console.WriteLine("|       1 - Cadastrar Aluno      |");
                Console.WriteLine("|       2 - Lançar Notas         |");
                Console.WriteLine("|       3 - Lançar Faltas        |");
                Console.WriteLine("|       4 - Listar Alunos        |");
                Console.WriteLine("|       0 - Cadastrar Aluno      |");
                Console.WriteLine("+--------------------------------+");
                Console.WriteLine("| > Opção escolhida: ");
                int.TryParse(Console.ReadLine(), out opcao);

                switch (opcao)
                {
                    case 1:
                        CadastrarAluno();
                        break;
                    case 2:
                        LancarNota();
                        break;
                    case 3:
                        LancarFaltar();
                        break;
                    case 4:
                        ConsultarAlunos();
                        break;
                    case 0:
                        Console.WriteLine("Desligando");
                        break;
                    default:
                        Console.WriteLine("Opção Inválida");
                        break;
                }
            } while (opcao == 0);
        }

        private static void CadastrarAluno() 
        { }

        private static void LancarNota()
        { }

        private static void LancarFaltar()
        { }

        private static void ConsultarAlunos()
        { }
    }
}