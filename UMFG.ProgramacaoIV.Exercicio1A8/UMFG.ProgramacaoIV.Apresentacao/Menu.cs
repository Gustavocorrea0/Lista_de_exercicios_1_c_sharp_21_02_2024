using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMFG.ProgramacaoIV.Apresentacao
{
    internal class Menu
    {
        private static ConversaoDeMoeda conversaoDeMoeda = new ConversaoDeMoeda();
        private static CalculoDeKMPorLitros calculoDeKMPorLitros = new CalculoDeKMPorLitros();
        private static CalculoDeIdade calculoDeIdade = new CalculoDeIdade();
        private static Calculadora calculadora = new Calculadora();
        private static QuantidadeDeVogaisEConsoantes quantidadeVogais = new QuantidadeDeVogaisEConsoantes();
        private static CalculoDeFaixaEtaria calculoFaixaEtaria = new CalculoDeFaixaEtaria();

        public void Sistema()
        {

            var opcao = 0;

            do
            {
                Console.WriteLine("+----------------------------------------------+");
                Console.WriteLine("|                MENU DE OPÇÕES                |");
                Console.WriteLine("+----------------------------------------------+");
                Console.WriteLine("|                1 - Exercicio 1               |");
                Console.WriteLine("|                2 - Exercicio 2               |");
                Console.WriteLine("|                3 - Exercicio 3               |");
                Console.WriteLine("|                4 - Exercicio 4               |");
                Console.WriteLine("|                5 - Exercicio 5               |");
                Console.WriteLine("|                6 - Exercicio 6               |");
                Console.WriteLine("|                7 - Exercicio 7               |");
                Console.WriteLine("|                8 - Exercicio 8               |");
                Console.WriteLine("|                10 - Sair                     |");
                Console.WriteLine("+----------------------------------------------+");
                Console.WriteLine("| > Qual é a opção:");
                int.TryParse(Console.ReadLine(), out opcao);

                switch (opcao)
                {
                    case 1:
                        Exercicio1();
                        break;
                    case 2:
                        Exercicio2();
                        break;
                    case 3:
                        Exercicio3();
                        break;
                    case 4:
                        Exercicio4();
                        break;
                    case 5:
                        Exercicio5();
                        break;
                    case 6:
                        Exercicio6();
                        break;
                    case 7:
                        Exercicio7();
                        break;
                    case 8:
                        Exercicio8();
                        break;
                    case 10:
                        Console.WriteLine("+-------------------------------+");
                        Console.WriteLine("|          Desligando           |");
                        Console.WriteLine("+-------------------------------+");
                        break;
                    default:
                        Console.WriteLine("+-------------------------------+");
                        Console.WriteLine("|         Opção Inválida        |");
                        break;
                }
            } while (opcao != 10);
        }

        private void Exercicio1() 
        {
            try
            {
                Console.WriteLine("+----------------------------------------------+");
                Console.WriteLine("|         Conversão de Real Para Dolar         |");
                Console.WriteLine("+----------------------------------------------+");
                Console.WriteLine("| > Valor em Real: ");
                var valorReal = Console.ReadLine();
                double valorConvertidoReal = Convert.ToDouble(valorReal);
                conversaoDeMoeda.ConverterRealParaDolar(valorConvertidoReal);
            }
            catch (Exception ex)
            {
                Console.WriteLine("+----------------------------------------------+");
                Console.WriteLine("|          Falha de Digitação de valor         |");
            }
        }

        private void Exercicio2()
        {
            try
            {
                Console.WriteLine("+----------------------------------------------+");
                Console.WriteLine("|          Conversão de Dolar para Real        |");
                Console.WriteLine("+----------------------------------------------+");
                Console.WriteLine("| > Valor em Dolar: ");
                var valorDolar = Console.ReadLine();
                double valorConvertidoDolar = Convert.ToDouble(valorDolar);
                conversaoDeMoeda.ConverterDolarParaReal(valorConvertidoDolar);
            }
            catch (Exception ex)
            {
                Console.WriteLine("+----------------------------------------------+");
                Console.WriteLine("|         Falha de Digitação de valor          |");
            }
        }

        private void Exercicio3()
        {
            try
            {
                Console.WriteLine("+----------------------------------------------+");
                Console.WriteLine("|              Média de KM por Litro           |");
                Console.WriteLine("+----------------------------------------------+");
                Console.WriteLine("| > KM percorridos: ");
                var kmPercorrido = Console.ReadLine();
                Console.WriteLine("+----------------------------------------------+");
                Console.WriteLine("| > Litros gastos: ");
                var litrosGastos = Console.ReadLine();

                double kmPercorridoConvertido = Convert.ToDouble(kmPercorrido);
                double litrosGastosConvertido = Convert.ToDouble(litrosGastos);
                calculoDeKMPorLitros.CalcularMedia(kmPercorridoConvertido, litrosGastosConvertido);

            }
            catch (Exception ex)
            {
                Console.WriteLine("+----------------------------------------------+");
                Console.WriteLine("|        Falha de Digitação de valor           |");
            }
        }

        private void Exercicio4()
        {
            try
            {
                Console.WriteLine("+----------------------------------------------+");
                Console.WriteLine("|               Calculo de Idade               |");
                Console.WriteLine("+----------------------------------------------+");
                Console.WriteLine("| > Qual é o ano de nascimento: ");
                var anoNascimento = Console.ReadLine();
                int anoNascimentoConvertido = int.Parse(anoNascimento);
                calculoDeIdade.CalcularIdade(anoNascimentoConvertido);
            }
            catch (Exception ex)
            {
                Console.WriteLine("+----------------------------------------------+");
                Console.WriteLine("|          Falha de Digitação de valor         |");
            }
        }

        private void Exercicio5() 
        {
            try
            {
                string tipoConta;
                do
                {
                    Console.WriteLine("+----------------------------------------------+");
                    Console.WriteLine("|                  Calculadora                 |");
                    Console.WriteLine("+----------------------------------------------+");
                    Console.WriteLine("|                S - Somar                     |");
                    Console.WriteLine("|                U - Subtrair                  |");
                    Console.WriteLine("|                M - Multiplicar               |");
                    Console.WriteLine("|                D - Dividir                   |");
                    Console.WriteLine("|                R - Resto da Divisao          |");
                    Console.WriteLine("|                F - Sair                      |");
                    Console.WriteLine("+----------------------------------------------+");
                    Console.WriteLine("| > Opção escolhida: ");
                    tipoConta = Console.ReadLine();

                    if (tipoConta.ToUpper().Equals("F")) 
                    {
                        Console.WriteLine("+----------------------------------------------+");
                        Console.WriteLine("|               Voltando ao Menu               |");
                        Sistema();
                    }

                    Console.WriteLine("+----------------------------------------------+");
                    Console.WriteLine("| > Primeiro valor:");
                    var valorUm = Console.ReadLine();

                    Console.WriteLine("+----------------------------------------------+");

                    Console.WriteLine("| > Segundo valor:");
                    var valorDois = Console.ReadLine();

                    double valorUmConvertido = Convert.ToDouble(valorUm);
                    double valorDoisConvertido = Convert.ToDouble(valorDois);

                    switch (tipoConta.ToUpper())
                    {

                        case "S":
                            calculadora.Somar(valorUmConvertido, valorDoisConvertido);
                            break;
                        case "U":
                            calculadora.Subtrair(valorUmConvertido, valorDoisConvertido);
                            break;
                        case "M":
                            calculadora.Multiplicar(valorUmConvertido, valorDoisConvertido);
                            break;
                        case "D":
                            calculadora.Dividir(valorUmConvertido, valorDoisConvertido);
                            break;
                        case "R":
                            calculadora.RestoDivisao(valorUmConvertido, valorDoisConvertido);
                            break;
                        default:
                            Console.WriteLine("+----------------------------------------------+");
                            Console.WriteLine("|                Opção Inválida                |");
                            break;
                    }

                } while (!tipoConta.ToUpper().Equals("F")) ;


            }
            catch (Exception ex)
            {
                Console.WriteLine("+-------------------------------+");
                Console.WriteLine("|  Falha de Digitação de valor  |");
            }
        }

        private void Exercicio6() 
        {
            try
            {
                Console.WriteLine("+----------------------------------------------+");
                Console.WriteLine("|             Quantidade de Vogais             |");
                Console.WriteLine("+----------------------------------------------+");
                Console.WriteLine("| > Qual é o nome: ");
                var nomeUsuario = Console.ReadLine();
                string nomeUsuarioConvertido = nomeUsuario.ToString();
                quantidadeVogais.ContarVogais(nomeUsuarioConvertido);

            }
            catch (Exception ex)
            {
                Console.WriteLine("+----------------------------------------------+");
                Console.WriteLine("|          Falha de Digitação do nome          |");
            }
        }
        
        private void Exercicio7() 
        {
            try
            {
                Console.WriteLine("+----------------------------------------------+");
                Console.WriteLine("|           Quantidade de Consoantes           |");
                Console.WriteLine("+----------------------------------------------+");
                Console.WriteLine("| > Qual é o nome: ");
                var nomeUsuario = Console.ReadLine();
                string nomeUsuarioConvertido = nomeUsuario.ToString();
                quantidadeVogais.ContarConsantes(nomeUsuarioConvertido);

            }
            catch (Exception ex)
            {
                Console.WriteLine("+----------------------------------------------+");
                Console.WriteLine("|          Falha de Digitação de nome          |");
            }
        }

        private void Exercicio8() 
        {
            try
            {
                Console.WriteLine("+----------------------------------------------+");
                Console.WriteLine("|            Calculo de Faixa Etaria           |");
                Console.WriteLine("+----------------------------------------------+");
                Console.WriteLine("| > Nome: ");
                string nomeUsuario = Console.ReadLine();
                Console.WriteLine("+----------------------------------------------+");
                Console.WriteLine("| > Data de Nascimento(dd/mm/aaaa): ");
                DateTime dataNascimento = DateTime.Parse(Console.ReadLine());

                calculoFaixaEtaria.CalcularFaixaEtaria(dataNascimento, nomeUsuario);
            }
            catch (Exception ex)
            {
                Console.WriteLine("+----------------------------------------------+");
                Console.WriteLine("|              Falha de Digitação              |");
            }
        }
    }
}
