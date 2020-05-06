using System;
using Teste_Coopavel.Entities;
using System.Collections.Generic;

namespace Teste_Coopavel
{
    class Program
    {
        static void Main()
        {
            int opcao = 0;
            List<Associados> lista = new List<Associados>();

            while (opcao != 3)
            {
                try
                {

                    Console.WriteLine();
                    Console.WriteLine("             Bem-vindo ao sistema de tickets de almoço - Show Rural");
                    Console.WriteLine();

                    Console.WriteLine("O que deseja fazer?");
                    Console.WriteLine("1 - Cadastrar a retirada do ticket do associado");
                    Console.WriteLine("2 - Verificar a retirada do ticket do associado");
                    Console.WriteLine("3 - Saldo final do evento e Saída do programa");
                    Console.Write("Opção: ");
                    opcao = int.Parse(Console.ReadLine());


                    switch (opcao)
                    {

                        case 1:

                            Console.WriteLine();

                            Console.Write("Informe o codigo de cadastro do associado: ");
                            int Codigo = int.Parse(Console.ReadLine());

                            Console.Write("Informe o nome do associado: ");
                            string Nome = Console.ReadLine();

                            Console.WriteLine("Ja retirou os tickets? (S/N)");
                            char Resposta = char.Parse(Console.ReadLine());

                            if (Resposta == 'S' || Resposta == 's')
                            {
                                Console.Write("Informe a quantidade de tickets: ");
                                int Tickets = int.Parse(Console.ReadLine());
                                Console.Clear();
                                Associados cadastroAssociado = new Associados(Nome, Tickets, Codigo);
                                lista.Add(cadastroAssociado);
                                Console.WriteLine("     Cadastrado com sucesso!!");
                                
                            }
                            else if (Resposta == 'N' || Resposta == 'n')
                            {
                                Console.Clear();
                                Associados cadastroAssociado = new Associados(Nome, Codigo);
                                lista.Add(cadastroAssociado);
                                Console.WriteLine("     Cadastrado com sucesso!!");
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Opção inválida!!!");
                            }

                            break;

                        case 2:

                            Console.WriteLine();
                            Console.Write("Informe o nome do associado: ");
                            string pesquisaNome = Console.ReadLine();

                            foreach (Associados consultado in lista)
                            {
                                if (consultado.Nome == pesquisaNome && consultado.Tickets > 0)
                                {
                                    Console.WriteLine("O associado informado já retirou seus tickets!");
                                    Console.WriteLine("Retirou: " + consultado.Tickets);
                                    Console.WriteLine();
                                }
                                else
                                {
                                    Console.WriteLine("O associado informado ainda não pegou os seus tickets!");
                                    Console.WriteLine();
                                }
                            }

                            Console.WriteLine("Pressione qualquer tecla para voltar!!");
                            Console.ReadLine();

                            Console.Clear();
                            break;

                        default:

                            Console.WriteLine();
                            Console.WriteLine("Codigo, Nome, Numero de tickets");

                            foreach (Associados saldoFinal in lista)
                            {
                                if (saldoFinal.JaRetirou == true)
                                {
                                    Console.WriteLine(saldoFinal.ToString());
                                }
                            }

                            Console.WriteLine("Pressione qualquer tecla para sair!!");
                            Console.ReadLine();

                            break;

                    }
                }
                catch (Exception e)
                {
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine("Error: " + e.Message);
                }
            }

        }
    }
}
