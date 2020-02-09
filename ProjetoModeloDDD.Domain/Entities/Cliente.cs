using System;

namespace ProjetoModeloDDD.Domain.Entities
{
    public class Cliente
    {
        public int ClienteId { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Email { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }


        //regra de negocio
        public bool ClienteEspecial(Cliente cliente) //Validacao se o cliente eh especial. Recebe um Cliente, chamado cliente
        {
            return cliente.Ativo && DateTime.Now.Year - cliente.DataCadastro.Year >= 5; //cliente tem que ser ativo e tem q ter 5 ou mais anos de cadastro

        }
    }
}
