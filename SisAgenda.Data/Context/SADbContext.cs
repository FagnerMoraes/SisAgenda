using Microsoft.EntityFrameworkCore;
using SisAgenda.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SisAgenda.Data.Context
{
    public class SADbContext : DbContext
    {
        public SADbContext(DbContextOptions<SADbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
            .ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        public DbSet<Paciente> Pacientes { get; set; } = null!;
    }
}
