using System;

namespace SistemaDePagamentos
{
    public class PessoaFisica : Pessoa
    {
        public string cpf { get; set; }
        public DateTime dataNascimento { get; set; }
    }
}