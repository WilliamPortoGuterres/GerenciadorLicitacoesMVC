using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GerenciadorLicitacoesMVC.Models
{
    public class UsuarioEntity
    {
        [Key]
        public int UsuarioId { get; set; }

        [Required]
        [StringLength(100)]
        public string Nome { get; set; }

        // Outros campos relevantes para o usuário, como e-mail, senha, etc.

        // Relacionamento com Licitações
        public virtual ICollection<LicitacaoEntity> Licitacoes { get; set; }
    }
}