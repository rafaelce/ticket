using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Clientes
{
    public class List
    {
        public class Query : IRequest<List<Cliente>> { }

        public class Handler : IRequestHandler<Query, List<Cliente>>
        {
            private readonly DataContext _context;
            public Handler(DataContext context) => _context = context;
            public async Task<List<Cliente>> Handle(Query request, CancellationToken cancellationToken)
            => await _context.Clientes.ToListAsync();
        }
    }
}