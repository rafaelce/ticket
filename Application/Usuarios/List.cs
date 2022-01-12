using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Usuarios
{
    public class List
    {
        public class Query : IRequest<List<Usuario>> { }

        public class Handler : IRequestHandler<Query, List<Usuario>>
        {
            private readonly DataContext _context;
            public Handler(DataContext context) => _context = context;
            public async Task<List<Usuario>> Handle(Query request, CancellationToken cancellationToken)
            => await _context.Usuarios.ToListAsync();
        }
    }
}