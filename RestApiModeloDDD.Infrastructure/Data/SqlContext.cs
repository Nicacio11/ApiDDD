using Microsoft.EntityFrameworkCore;
using RestApiModeloDDD.Domain.Entities;
using RestApiModeloDDD.Infrastructure.Data.Mapping;
using System;
using System.Linq;
using System.Reflection;

namespace RestApiModeloDDD.Infrastructure.Data
{
    public class SqlContext: DbContext
    {
        public SqlContext()
        {

        }

        public SqlContext(DbContextOptions<SqlContext> options): base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Cliente>(new ClienteMap().Configure);
            modelBuilder.Entity<Produto>(new ProdutoMap().Configure);
        }
        public DbSet<Cliente> clientes { set; get; }
        public DbSet<Produto> produtos { get; set; }

        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("DataCadastro") != null))
            {
                if(entry.State == EntityState.Added)
                {
                    entry.Property("DataCadastro").CurrentValue = DateTime.Now;
                }
                if (entry.State == EntityState.Modified)
                {
                    entry.Property("DataCadastro").IsModified = false;
                }
            }
            return base.SaveChanges();
        }
    }
}
