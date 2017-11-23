using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoModeloDDD.Dominio.Entidades
{
    public class Comentario
    {
        public int ComentarioID { get; set; }
        public string Texto { get; set; }
        public DateTime DataCadastro { get; set; }

        public Nullable<int> UsuarioID { get; set; }
        public virtual Usuario Usuario { get; set; }
        public Nullable<int> PostID { get; set; }
        public virtual Post Post { get; set; }
    }
}
