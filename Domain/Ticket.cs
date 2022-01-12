using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain
{
    public class Ticket
    {
        public Guid Id { get; set; }

        [ForeignKey("UsuarioAberturaId")]
        public virtual Usuario UsuarioAbertura { get; set; }

        [ForeignKey("UsuarioConclusaoId")]
        public virtual Usuario UsuarioConclusao { get; set; }

        [ForeignKey("ClienteId")]
        public virtual Cliente Cliente { get; set; }

        [ForeignKey("TicketSituacaoId")]
        public virtual TicketSituacao TicketSituacao { get; set; }
        public int Codigo { get; set; }
        public DateTime DataAbertura { get; set; }
        public DateTime DataConclusao { get; set; }

    }
}