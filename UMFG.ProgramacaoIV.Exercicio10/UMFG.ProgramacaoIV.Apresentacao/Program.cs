using UMFG.ProgramacaoIV.Dominio.Entities;
using UMFG.ProgramacaoIV.Dominio.Interfaces;
using UMFG.ProgramacaoIV.Dominio.Services;

namespace UMFG.ProgramacaoIV.Apresentacao
{
    internal class Program
    {
        private const string C_USUARIO_PADRAO = "userPadrao@umfg.edu.br";

        private static IAlunoService _servico = new AlunoService();


        static void Main(string[] args)
        {
            Menu();
        }

        private static void Menu()
        {

            var opcao = 9;
            try
            {
                do
                {
                    Console.WriteLine("+--------------------------------+");
                    Console.WriteLine("|         Menu de Alunos         |");
                    Console.WriteLine("+--------------------------------+");
                    Console.WriteLine("|       1 - Cadastrar Aluno      |");
                    Console.WriteLine("|       2 - Lançar Notas         |");
                    Console.WriteLine("|       3 - Lançar Faltas        |");
                    Console.WriteLine("|       4 - Listar Alunos        |");
                    Console.WriteLine("|       0 - Sair                 |");
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
                            LancarFaltas();
                            break;
                        case 4:
                            Console.Clear();
                            RelacaoDeAlunos();
                            break;
                        case 0:
                            Console.Clear();
                            Console.WriteLine("+--------------------------------+");
                            Console.WriteLine("|           Desligando           |");
                            Environment.Exit(1);
                            break;
                        default:
                            Console.Clear();
                            Console.WriteLine("+--------------------------------+");
                            Console.WriteLine("|         Opção Inválida         |");
                            Menu();
                            break;
                    }

                } while (opcao != 0);

            } catch (Exception ex) 
            {
                Console.Clear();
                Console.WriteLine("+--------------------------------+");
                Console.WriteLine("| > Falha tipo: " + ex.Message);
            }
            

        }

        private static void CadastrarAluno()
        {
            try
            {
                int ra;
                Console.Clear();
                Console.WriteLine("+--------------------------------+");
                Console.WriteLine("|         Cadastrar Aluno        |");
                Console.WriteLine("+--------------------------------+");
                Console.WriteLine("| > Nome do Aluno: ");
                string nomeAlunoNovo = Console.ReadLine();

                Console.WriteLine("+--------------------------------+");
                Console.WriteLine("| > RA do Aluno: ");
                int.TryParse(Console.ReadLine(), out ra);

                Console.Clear();
                var novoAluno = new Aluno(nomeAlunoNovo, ra, C_USUARIO_PADRAO, C_USUARIO_PADRAO);
                _servico.adicionarAluno(novoAluno);
            }
            catch (Exception ex)
            {
                Console.Clear();
                Console.WriteLine("+--------------------------------+");
                Console.WriteLine("| > Falha tipo: " + ex.Message);
            }
     
            Menu();
        }

        private static void LancarNota()
        {
            int raDoAluno;
            double notaProva;
            double notaTrabalho;

            try
            {
                Console.Clear();
                Console.WriteLine("+--------------------------------+");
                Console.WriteLine("|    Lançar ou Atualizar Nota    |");
                Console.WriteLine("+--------------------------------+");
                Console.WriteLine("| > RA do Aluno: ");
                int.TryParse(Console.ReadLine(), out raDoAluno);

                Console.WriteLine("+--------------------------------+");
                Console.WriteLine("| > Nota de Prova: ");
                double.TryParse(Console.ReadLine(), out notaProva);

                Console.WriteLine("+--------------------------------+");
                Console.WriteLine("| > Nota de Trabalho: ");
                double.TryParse(Console.ReadLine(), out notaTrabalho);

                Console.Clear();
                if (notaTrabalho >= 0 && notaTrabalho <= 10 && notaProva >= 0 && notaProva <= 10)
                {   
                    _servico.adicionarNota(raDoAluno, notaProva, notaTrabalho);
                }
                else
                {
                    Console.WriteLine("+--------------------------------+");
                    Console.WriteLine("|Notas inválidas (Min=0 e MAX=10)|");
                }

            } catch (Exception ex) 
            {
                Console.Clear();
                Console.WriteLine("+--------------------------------+");
                Console.WriteLine("| > Falha tipo: " + ex.Message);
            }
            
            Menu();

        }

        private static void LancarFaltas()
        {
            int raDoAluno;
            int numeroDeFaltas;

            try 
            {
                Console.Clear();
                Console.WriteLine("+--------------------------------+");
                Console.WriteLine("|   Lançar ou Atualizar Faltas   |");
                Console.WriteLine("+--------------------------------+");
                Console.WriteLine("| > RA do Aluno: ");
                int.TryParse(Console.ReadLine(), out raDoAluno);

                Console.WriteLine("+--------------------------------+");
                Console.WriteLine("| > Número de Faltas: ");
                int.TryParse(Console.ReadLine(), out numeroDeFaltas);

                Console.Clear();
                if (numeroDeFaltas >= 0 && numeroDeFaltas <= 25)
                {
                    _servico.adicionarFaltas(raDoAluno, numeroDeFaltas);
                }
                else 
                {
                    Console.WriteLine("+--------------------------------+");
                    Console.WriteLine("|        Faltas inválidas        |");
                }
            } 
            catch (Exception ex) 
            {
                Console.Clear();
                Console.WriteLine("+--------------------------------+");
                Console.WriteLine("| > Falha tipo: " + ex.Message);
            }
  
            Menu();
        }

        private static void RelacaoDeAlunos()
        {
            var op = 0;
            try
            {
                
                do
                {
                    Console.WriteLine("+--------------------------------+");
                    Console.WriteLine("|       Alunos Cadastrados       |");
                    Console.WriteLine("+--------------------------------+");
                    Console.WriteLine("|     1 - para consultar         |");
                    Console.WriteLine("|     2 - para voltar ao menu    |");
                    Console.WriteLine("+--------------------------------+");
                    Console.WriteLine("| > Opção escolhida:  ");
                    int.TryParse(Console.ReadLine(), out op);

                    switch (op)
                    {
                        case 1:
                            Console.Clear();
                            Console.WriteLine("+--------------------------------+");
                            Console.WriteLine("|       Alunos Cadastrados       |");
                            foreach (var item in _servico.obterAlunos())
                            {
                                Console.WriteLine(item.ToString());
                            }
                            Console.WriteLine("");

                            RelacaoDeAlunos();
                            break;
                        case 2:
                            Console.Clear();
                            Menu();
                            break;
                        default:
                            Console.Clear();
                            Console.WriteLine("+--------------------------------+");
                            Console.WriteLine("|         Opção Inválida         |");
                            RelacaoDeAlunos();
                            break;
                    }
                } while (op != 2);

            } catch (Exception ex) 
            {
                Console.WriteLine("+--------------------------------+");
                Console.WriteLine("| > Falha tipo: " + ex.Message);
            }
            
            
        }

    }
}
