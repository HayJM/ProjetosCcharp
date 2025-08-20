using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ModuloAPI.Entities;

namespace ModuloAPI.Context
{
    public class AgendaContext : DbContext
    {
        public AgendaContext(DbContextOptions<AgendaContext> options) : base(options)
        {
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // modelBuilder.Entity<Entities.Contato>().HasKey(c => c.Id);
            // modelBuilder.Entity<Entities.Contato>().Property(c => c.Nome).IsRequired().HasMaxLength(100);
            // modelBuilder.Entity<Entities.Contato>().Property(c => c.Telefone).IsRequired().HasMaxLength(15);
            // modelBuilder.Entity<Entities.Contato>().Property(c => c.Ativo).IsRequired();
        }
        public DbSet<Entities.Contato> Contatos { get; set; }
        
    }
}