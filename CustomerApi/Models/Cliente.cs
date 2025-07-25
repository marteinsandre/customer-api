using System;

namespace CustomerApi.Models
{
    /// <summary>
    /// Entidade que representa um cliente.
    /// </summary>
    public class Cliente
    {
        /// <summary>
        /// Identificador único do cliente.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Nome do cliente.
        /// </summary>
        public required string Nome { get; set; }

        /// <summary>
        /// Endereço do cliente.
        /// </summary>
        public required string Endereco { get; set; }

        /// <summary>
        /// Data de nascimento do cliente.
        /// </summary>
        public DateTime DataNascimento { get; set; }
    }
} 