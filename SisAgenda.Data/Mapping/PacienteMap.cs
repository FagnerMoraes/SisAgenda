using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SisAgenda.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisAgenda.Data.Mapping
{
    public class PacienteMap : IEntityTypeConfiguration<Paciente>
    {
        public void Configure(EntityTypeBuilder<Paciente> builder)
        {
            builder.ToTable("paciente");
            builder.Property(p => p.Nome).IsRequired().HasMaxLength(100);
            builder.Property(p => p.CNS).IsRequired().HasMaxLength(15);
        }
    }
}
