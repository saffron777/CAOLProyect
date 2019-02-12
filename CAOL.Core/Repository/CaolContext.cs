using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using CAOL.Core.Entities;
using MySql.Data.EntityFrameworkCore.Extensions;

namespace CAOL.Core.Repository
{
    public class CaolContext: DbContext
    {
        public CaolContext(DbContextOptions<CaolContext> options):base(options)
        {

        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseMySQL("server=localhost;database=library;user=user;password=password");
        //}

        public virtual DbSet<cao_sistema> Cao_sistema { get; set; }
        public virtual DbSet<cao_salario> Cao_salario { get; set; }
        public virtual DbSet<cao_os> Cao_os { get; set; }
        public virtual DbSet<cao_fatura> Cao_fatura { get; set; }
        public virtual DbSet<permissao_sistema> Permissao_sistema { get; set; }
        public virtual DbSet<cao_usuario> Cao_usuario { get; set; }

        public virtual DbSet<cao_cliente> Cao_cliente { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<cao_salario>()
                .HasKey(k => new { k.co_usuario, k.dt_alteracao });

            modelBuilder.Entity<permissao_sistema>()
                .HasKey(k => new { k.co_usuario, k.co_tipo_usuario, k.co_sistema });
        }
    }
}
