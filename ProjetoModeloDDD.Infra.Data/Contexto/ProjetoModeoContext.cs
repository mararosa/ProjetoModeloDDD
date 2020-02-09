using System.Data.Entity;

namespace ProjetoModeloDDD.Infra.Data.Contexto
{
    public class ProjetoModeoContext : DbContext
    {
        public ProjetoModeoContext()
            : base("ProjetoModeloDD") //contrutor base que leva a string de conexao
        {

        }


    }
}
