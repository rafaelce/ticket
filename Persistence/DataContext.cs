using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        // public DbSet<Activity> Activities { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<TicketSituacao> TicketSituacao { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<TicketAnotacao> TicketAnotacoes { get; set; }

    }
}