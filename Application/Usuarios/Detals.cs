using System;
using System.Threading;
using System.Threading.Tasks;
using Domain;
using MediatR;
using Persistence;

namespace Application.Usuarios
{
    public class Detals
    {
        public class Query : IRequest<Usuario>
        {
            public Guid Id { get; set; }
        }

        public class Handler : IRequestHandler<Query, Usuario>
        {
            private readonly DataContext _context;
            public Handler(DataContext context) => _context = context;

            public async Task<Usuario> Handle(Query request, CancellationToken cancellationToken)
            => await _context.Usuarios.FindAsync(request.Id);

        }
    }
}