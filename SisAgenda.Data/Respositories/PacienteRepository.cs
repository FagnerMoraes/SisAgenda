using Microsoft.EntityFrameworkCore;
using SisAgenda.Data.Context;
using SisAgenda.Domain.Entities;
using SisAgenda.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisAgenda.Data.Respositories
{
    public class PacienteRepository : IPacienteRepository
    {
        private readonly SADbContext _context;

        public PacienteRepository(SADbContext context)
        {
            _context = context;
        }


        public async Task<IEnumerable<Paciente>> GetAllAsync()
        {
            return await _context.Pacientes.ToListAsync();
        }

        public async Task<object> PostAsync(Paciente paciente)
        {
            _context.Add(paciente);
            await _context.SaveChangesAsync();
            return paciente.Id;
        }
    }
}
