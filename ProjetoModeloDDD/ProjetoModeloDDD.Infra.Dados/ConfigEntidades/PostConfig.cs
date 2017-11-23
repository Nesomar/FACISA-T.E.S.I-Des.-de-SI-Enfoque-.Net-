using ProjetoModeloDDD.Dominio.Entidades;
using System.Data.Entity.ModelConfiguration;

namespace ProjetoModeloDDD.Infra.Dados.ConfigEntidades
{
    public class PostConfig : EntityTypeConfiguration<Post>
    {
        public PostConfig()
        {
            HasKey(p => p.PostID);

            Property(p => p.Titulo).IsRequired();

            Property(p => p.Texto).IsRequired().HasMaxLength(250);

            HasRequired(p => p.Usuario).WithMany().HasForeignKey(p => p.UsuarioId);

            HasRequired(p => p.Area).WithMany().HasForeignKey(p => p.AreaId);
        }
    }
}
