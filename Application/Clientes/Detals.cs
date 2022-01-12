using System;
using System.Threading;
using System.Threading.Tasks;
using Domain;
using MediatR;
using Persistence;

namespace Application.Clientes
{
    public class Detals
    {
        public class Query : IRequest<Cliente>
        {
            public Guid Id { get; set; }
        }

        public class Handler : IRequestHandler<Query, Cliente>
        {
            private readonly DataContext _context;
            public Handler(DataContext context) => _context = context;

            public async Task<Cliente> Handle(Query request, CancellationToken cancellationToken)
            => await _context.Clientes.FindAsync(request.Id);

        }
    }
}