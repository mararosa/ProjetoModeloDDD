using ProjetoModeloDDD.Domain.Entities;
using System.Data.Entity;

namespace ProjetoModeloDDD.Infra.Data.Contexto
{
    public class ProjetoModeloContext : DbContext
    {
        public ProjetoModeloContext()
            : base("ProjetoModeloDD") //contrutor base que leva a string de conexao
        {

        }

        public DbSet<Cliente> Clientes { get; set; } //Criando DB, e a tabela de clientes
    }
}
