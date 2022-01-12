using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain
{
    public class TicketAnotacao
    {
        public Guid Id { get; set; }
        public Guid IdTicket { get; set; }
        public virtual Ticket Ticket { get; set; }
        public Guid IdUsuario { get; set; }
        public virtual Usuario Usuario { get; set; }
        public string Texto { get; set; }
        public DateTime Data { get; set; }
    }
}