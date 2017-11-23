using ProjetoModeloDDD.Dominio.Entidades;
using ProjetoModeloDDD.Infra.Dados.ConfigEntidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoModeloDDD.Infra.Dados.Contexto
{
    public class ContextoAplicacao : DbContext
    {
        public ContextoAplicacao() : base("ProjetoModeloContexto")
        {
        }
        public virtual DbSet<Usuario> Usuarios { get; set; }
        public virtual DbSet<Post> Postagens { get; set; }
        public virtual DbSet<Area> Areas { get; set; }
        public virtual DbSet<Comentario> Comentarios { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Properties()
                .Where(p => p.Name == p.ReflectedType.Name + "ID")
                .Configure(p => p.IsKey());
            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("varchar"));
            modelBuilder.Properties<string>()
                .Configure(p => p.HasMaxLength(100));

            modelBuilder.Configurations.Add(new UsuarioConfig());

            modelBuilder.Configurations.Add(new PostConfig());

            modelBuilder.Configurations.Add(new AreaConfig());

            modelBuilder.Configurations.Add(new ComentarioConfig());
        }

        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("DataCadastro") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("DataCadastro").CurrentValue = DateTime.Now;
                }
                if (entry.State == EntityState.Modified)
                {
                    entry.Property("DataCastro").IsModified = false;
                }
            }
            return base.SaveChanges();
        }
    }
}
