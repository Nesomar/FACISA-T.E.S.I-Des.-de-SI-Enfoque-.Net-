using ProjetoModeloDDD.Dominio.Entidades;
using System.Data.Entity.ModelConfiguration;

namespace ProjetoModeloDDD.Infra.Dados.ConfigEntidades
{
    public class ComentarioConfig : EntityTypeConfiguration<Comentario>
    {
        public ComentarioConfig()
        {
            HasKey(c => c.ComentarioID);

            Property(c => c.Texto).IsRequired().HasMaxLength(250);

            HasRequired(c => c.Post).WithMany().HasForeignKey(c => c.PostId);

            HasRequired(c => c.Usuario).WithMany().HasForeignKey(c => c.UsuarioId);
        }
    }
}
