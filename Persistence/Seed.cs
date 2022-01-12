using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;

namespace Persistence
{
    public class Seed
    {
        public static async Task SeedData(DataContext context)
        {
            if (!context.TicketSituacao.Any())
            {
                var situacao = new List<TicketSituacao>
                {
                    new TicketSituacao{ Nome = "Em atendimento" },
                    new TicketSituacao{ Nome = "Concluído"},
                };

                await context.TicketSituacao.AddRangeAsync(situacao);
            }

            await context.SaveChangesAsync();
        }
    }
}