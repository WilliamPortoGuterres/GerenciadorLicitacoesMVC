using GerenciadorLicitacoesMVC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;

namespace GerenciadorLicitacoesMVC.Infra
{
    public class PortalLicitacoesDbContext:DbContext
    {

        public PortalLicitacoesDbContext() : base("name=PortalLicitacoesContext")
        {
        }

        public DbSet<LicitacaoEntity> Licitacao { get; set; }
        public DbSet<UsuarioEntity> Usuario { get; set; }
    }
}