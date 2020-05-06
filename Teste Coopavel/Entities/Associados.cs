using System;
using System.Collections.Generic;

namespace Teste_Coopavel.Entities
{
    class Associados
    {

        public string Nome { get; private set; }
        public  int Tickets { get; private set; }
        public int Codigo { get; private set; }
        public bool JaRetirou { get; private set; }


        public Associados()
        {
        }

        public Associados(string nome, int tickets, int codigo)
        {
            Nome = nome;
            Tickets = tickets;
            Codigo = codigo;
            JaRetirou = true;
        }

        public Associados(string nome, int codigo) {

            Nome = nome;
            Tickets = 0;
            Codigo = codigo;
            JaRetirou = false;

        }
        public override string ToString()
        {
            return Codigo + ", " + Nome + ", " + Tickets;
        }

    }
}
