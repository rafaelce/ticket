using System;
using System.Collections.Generic;

namespace Domain
{
    public class Cliente
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Codigo { get; set; }
        public List<Ticket> Tickets { get; set; }
    }
}