using ProjetoModeloDDD.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoModeloDDD.Infra.Dados.ConfigEntidades
{
    public class UsuarioConfig : EntityTypeConfiguration<Usuario>
    {
        public UsuarioConfig()
        {
            HasKey(u => u.UsuarioID);

            Property(u => u.Nome).IsRequired().HasMaxLength(150);

            Property(u => u.Email).IsRequired();
        }
    }
}
