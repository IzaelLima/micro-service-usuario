using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;
using MSUsuario.Mapping.Configurations;
using MSUsuario.Domain.Models;

namespace MSUsuario.Context
{
    [ExcludeFromCodeCoverage]
    public class SqlContext : DbContext
    {
        public SqlContext(DbContextOptions<SqlContext> options) : base(options){}

        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsuarioMapping());
        }
    }
}
