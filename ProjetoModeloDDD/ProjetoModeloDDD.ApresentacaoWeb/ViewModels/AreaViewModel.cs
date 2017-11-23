using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoModeloDDD.ApresentacaoWeb.ViewModels
{
    public class AreaViewModel
    {
        [Key]
        public int AreaID { get; set; }
        [Required(ErrorMessage = "Preencha o campo Nome")]
        [MaxLength(150, ErrorMessage = "Máximo de {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo de {0} caracteres")]
        public string Nome { get; set; }

        public virtual ICollection<PostViewModel> Postagens { get; set; }
    }
}