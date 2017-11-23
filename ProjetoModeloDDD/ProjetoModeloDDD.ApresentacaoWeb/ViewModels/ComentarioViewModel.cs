using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoModeloDDD.ApresentacaoWeb.ViewModels
{
    public class ComentarioViewModel
    {
        [Key]
        public int ComentarioID { get; set; }
        [Required(ErrorMessage = "Preencha o campo Comentário")]
        [MaxLength(300, ErrorMessage = "Máximo de {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo de {0} caracteres")]
        public string Texto { get; set; }
        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }


        public Nullable<int> UsuarioID { get; set; }
        public virtual UsuarioViewModel Usuario { get; set; }
        public Nullable<int> PostID { get; set; }
        public virtual PostViewModel Post { get; set; }
    }
}