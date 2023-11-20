using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GerenciadorLicitacoesMVC.Models
{
    public class LicitacaoEntity
    {
        [Key]
        public int LicitacaoId { get; set; }

        [Required]
        [StringLength(100)]
        public string Numero { get; set; }

        [Required]
        [StringLength(500)]
        public string Descricao { get; set; }

        [Required]
        public DateTime DataAbertura { get; set; }

        // Considerando Status como uma string simples. Pode ser substituído por um enum, se preferir.
        [Required]
        [StringLength(20)]
        public string Status { get; set; }

        // Chave estrangeira para Usuário - opcional, dependendo do seu design
        public int? UsuarioId { get; set; }
        public virtual UsuarioEntity Usuario { get; set; }
    }
}