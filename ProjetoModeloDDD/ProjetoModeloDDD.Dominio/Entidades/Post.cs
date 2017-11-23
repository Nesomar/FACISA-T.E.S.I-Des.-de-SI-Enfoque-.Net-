using System;
using System.Collections.Generic;

namespace ProjetoModeloDDD.Dominio.Entidades
{
    public class Post
    {
        public Post()
        {
            this.Comentarios = new HashSet<Comentario>();
        }
        public int PostID { get; set; }
        public string Titulo { get; set; }
        public string Texto { get; set; }
        public DateTime DataCadastro { get; set; }

        public Nullable<int> UsuarioID { get; set; }
        public virtual Usuario Usuario { get; set; }
        public Nullable<int> AreaID { get; set; }
        public virtual Area Area { get; set; }
        public virtual ICollection<Comentario> Comentarios { get; set; }
    }
}
