using System;
using Teste_Coopavel.Entities;
using System.Collections.Generic;

namespace Teste_Coopavel
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao = 0;

            while (opcao != 4)
            {
                Console.WriteLine();
                Console.WriteLine("             Bem-vindo ao sistema de tickets de almoço - Show Rural");
                Console.WriteLine();

                Console.WriteLine("O que deseja fazer?");
                Console.WriteLine("1 - Cadastrar a retirada do ticket do associado");
                Console.WriteLine("2 - Verificar a retirada do ticket do associado");
                Console.WriteLine("3 - Saldo final do evento");
                Console.WriteLine("4 - Sair");
                Console.Write("Opção: ");
                opcao = int.Parse(Console.ReadLine());


                if (opcao == 1)
                {
                    Console.WriteLine();
                    Console.Write("Informe o nome do associado: ");
                    string Nome = Console.ReadLine();

                    Console.Write("Informe a quantidade de tickets: ");
                    int Tickets = int.Parse(Console.ReadLine());

                    List<Associados> associados = new List<Associados>();

                    associados.Add(new Associados(Nome, Tickets));

                    Console.Clear();

                }
                else if (opcao == 2)
                {
                    Console.WriteLine();
                    Console.Write("Informe o nome do associado: ");
                    string Nome = Console.ReadLine();

                    Associados.PegouTicket(Nome);
                    Console.WriteLine("Pressione qualquer tecla para voltar!!");
                    Console.ReadLine();

                    Console.Clear();

                }
                else if (opcao == 3)
                {

                    Console.Clear();

                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Obrigado por utilizar!!");
                }
            }
        }
    }
}
