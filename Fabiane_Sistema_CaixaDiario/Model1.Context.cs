﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Fabiane_Sistema_CaixaDiario
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class CDFEntities : DbContext
    {
        public CDFEntities()
            : base("name=CDFEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Empresa> Empresas { get; set; }
        public virtual DbSet<Competencia> Competencias { get; set; }
        public virtual DbSet<ParteEnvolvida> ParteEnvolvidas { get; set; }
        public virtual DbSet<TipoMovimentacao> TipoMovimentacaos { get; set; }
        public virtual DbSet<TipoParteEnvolvida> TipoParteEnvolvidas { get; set; }
        public virtual DbSet<Movimentacao> Movimentacaos { get; set; }
    }
}
