using System;
using System.Collections.Generic;
using System.Linq;
using CustomerApi.Models;

namespace CustomerApi.Services
{
    /// <summary>
    /// Serviço responsável pela gestão dos clientes em memória.
    /// </summary>
    public class ClienteService
    {
        private readonly List<Cliente> _clientes = new();

        /// <summary>
        /// Retorna todos os clientes cadastrados.
        /// </summary>
        public IEnumerable<Cliente> ObterTodos()
        {
            return _clientes;
        }

        /// <summary>
        /// Busca um cliente pelo Id.
        /// </summary>
        public Cliente ObterPorId(Guid id)
        {
            return _clientes.FirstOrDefault(c => c.Id == id);
        }

        /// <summary>
        /// Adiciona um novo cliente.
        /// </summary>
        public Cliente Adicionar(Cliente cliente)
        {
            cliente.Id = Guid.NewGuid();
            _clientes.Add(cliente);
            return cliente;
        }

        /// <summary>
        /// Atualiza um cliente existente.
        /// </summary>
        public bool Atualizar(Guid id, Cliente clienteAtualizado)
        {
            var cliente = ObterPorId(id);
            if (cliente == null) return false;
            cliente.Nome = clienteAtualizado.Nome;
            cliente.Endereco = clienteAtualizado.Endereco;
            cliente.DataNascimento = clienteAtualizado.DataNascimento;
            return true;
        }

        /// <summary>
        /// Remove um cliente pelo Id.
        /// </summary>
        public bool Remover(Guid id)
        {
            var cliente = ObterPorId(id);
            if (cliente == null) return false;
            _clientes.Remove(cliente);
            return true;
        }
    }
} 