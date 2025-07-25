using Microsoft.AspNetCore.Mvc;
using CustomerApi.Models;
using CustomerApi.Services;
using System;
using System.Collections.Generic;

namespace CustomerApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClientesController : ControllerBase
    {
        private readonly ClienteService _clienteService;

        public ClientesController(ClienteService clienteService)
        {
            _clienteService = clienteService;
        }

        /// <summary>
        /// Retorna todos os clientes cadastrados.
        /// </summary>
        [HttpGet]
        public ActionResult<IEnumerable<Cliente>> Get()
        {
            return Ok(_clienteService.ObterTodos());
        }

        /// <summary>
        /// Retorna um cliente pelo Id.
        /// </summary>
        [HttpGet("{id}")]
        public ActionResult<Cliente> GetById(Guid id)
        {
            var cliente = _clienteService.ObterPorId(id);
            if (cliente == null) return NotFound();
            return Ok(cliente);
        }

        /// <summary>
        /// Adiciona um novo cliente.
        /// </summary>
        [HttpPost]
        public ActionResult<Cliente> Post([FromBody] Cliente cliente)
        {
            var novoCliente = _clienteService.Adicionar(cliente);
            return CreatedAtAction(nameof(GetById), new { id = novoCliente.Id }, novoCliente);
        }

        /// <summary>
        /// Atualiza um cliente existente.
        /// </summary>
        [HttpPut("{id}")]
        public IActionResult Put(Guid id, [FromBody] Cliente cliente)
        {
            var atualizado = _clienteService.Atualizar(id, cliente);
            if (!atualizado) return NotFound();
            return NoContent();
        }

        /// <summary>
        /// Remove um cliente pelo Id.
        /// </summary>
        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            var removido = _clienteService.Remover(id);
            if (!removido) return NotFound();
            return NoContent();
        }
    }
} 