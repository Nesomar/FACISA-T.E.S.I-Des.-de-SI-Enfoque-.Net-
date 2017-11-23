using System.Collections.Generic;

namespace ProjetoModeloDDD.Dominio.Entidades
{
    public class Area
    {
        public Area()
        {
            this.Postagens = new HashSet<Post>();
        }
        public int AreaID { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<Post> Postagens { get; set; }
    }
}
