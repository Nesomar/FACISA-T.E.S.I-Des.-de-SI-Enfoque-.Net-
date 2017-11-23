using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoModeloDDD.Dominio.Entidades
{
    public class Usuario
    {

        public Usuario()
        {
            this.Postagens = new HashSet<Post>();
            this.Comentarios = new HashSet<Comentario>();
        }

        public int UsuarioID { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime DataCadastro { get; set; }

        public virtual ICollection<Post> Postagens { get; set; }
        public virtual ICollection<Comentario> Comentarios { get; set; }
    }
}
