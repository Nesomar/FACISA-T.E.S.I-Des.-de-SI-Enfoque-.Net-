using ProjetoModeloDDD.Dominio.Entidades;
using System.Data.Entity.ModelConfiguration;

namespace ProjetoModeloDDD.Infra.Dados.ConfigEntidades
{
    public class AreaConfig : EntityTypeConfiguration<Area>
    {
        public AreaConfig()
        {
            HasKey(a => a.AreaID);

            Property(a => a.Nome).IsRequired();

        }
    }
}
