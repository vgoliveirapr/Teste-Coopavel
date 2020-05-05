using System;
using System.Collections.Generic;
using System.Text;

namespace Teste_Coopavel.Entities
{
    class Associados
    {

        public static string Nome { get; private set; }
        public static int Tickets { get; private set; }


        public Associados(){
        }

        public Associados(string nome, int tickets)
        {
            Nome = nome;
            Tickets = tickets;
        }

        public static void PegouTicket(string nome) { 
        
            
            if(Nome == nome && Tickets <= 0)
            {
                Console.WriteLine("O associado informado ainda não pegou os seus tickets!");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("O associado informado já retirou seus tickets!");
                Console.WriteLine("Retirou: " + Tickets);
                Console.WriteLine();
            }
        
        }

    }
}
