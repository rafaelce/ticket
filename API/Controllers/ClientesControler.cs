using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Application.Clientes;
using Domain;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class ClientesControler : BaseApiController
    {
        [HttpGet]
        public async Task<ActionResult<List<Cliente>>> GetClientes()
        => await Mediator.Send(new List.Query());

        [HttpGet("{id}")]
        public async Task<ActionResult<Cliente>> GetCliente(Guid id)
        => await Mediator.Send(new Detals.Query { Id = id });

        [HttpPost]
        public async Task<IActionResult> CreateCliente(Cliente client)
        => Ok(await Mediator.Send(new Create.Command { Cliente = client }));

        [HttpPut("{id}")]
        public async Task<IActionResult> EditCliente(Guid id, Cliente cliente)
        {
            cliente.Id = id;
            return Ok(await Mediator.Send(new Edit.Command { Cliente = cliente }));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCliente(Guid id)
        => Ok(await Mediator.Send(new Delete.Command { Id = id }));
    }
}