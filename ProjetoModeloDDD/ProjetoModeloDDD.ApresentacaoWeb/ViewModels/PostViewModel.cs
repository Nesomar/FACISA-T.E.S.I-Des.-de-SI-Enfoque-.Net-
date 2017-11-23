using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoModeloDDD.ApresentacaoWeb.ViewModels
{
    public class PostViewModel
    {
        [Key]
        public int PostID { get; set; }
        [Required(ErrorMessage = "Preencha o Título da Postagem")]
        [MaxLength(150, ErrorMessage = "Máximo de {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo de {0} caracteres")]
        public string Titulo { get; set; }
        [Required(ErrorMessage = "Preencha o campo Texto da Postagem")]
        [MaxLength(300, ErrorMessage = "Máximo de {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo de {0} caracteres")]
        public string Texto { get; set; }
        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }

        public Nullable<int> UsuarioID { get; set; }
        public virtual UsuarioViewModel Usuario { get; set; }
        public Nullable<int> AreaID { get; set; }
        public virtual AreaViewModel Area { get; set; }
        public virtual ICollection<ComentarioViewModel> Comentarios { get; set; }
    }
}