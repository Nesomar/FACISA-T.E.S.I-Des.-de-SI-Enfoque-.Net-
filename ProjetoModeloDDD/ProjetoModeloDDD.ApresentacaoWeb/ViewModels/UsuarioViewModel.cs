using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ProjetoModeloDDD.ApresentacaoWeb.ViewModels
{
    public class UsuarioViewModel
    {
        [Key]
        public int UsuarioID { get; set; }
        [Required(ErrorMessage ="Preencha o campo Nome")]
        [MaxLength(150, ErrorMessage ="Máximo de {0} caracteres")]
        [MinLength(2, ErrorMessage ="Mínimo de {0} caracteres")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Preencha o campo Email")]
        [MaxLength(100, ErrorMessage = "Máximo de {0} caracteres")]
        [EmailAddress(ErrorMessage ="Preencha com um email válido")]
        [DisplayName("E-mail")]
        public string Email { get; set; }
        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }

        public virtual ICollection<PostViewModel> Postagens { get; set; }
        public virtual ICollection<ComentarioViewModel> Comentarios { get; set; }
    }
}