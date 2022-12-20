using Microsoft.EntityFrameworkCore;
using SisAgenda.Data.Context;
using SisAgenda.Domain.Entities;
using SisAgenda.Domain.Interfaces.Repositories;

namespace SisAgenda.Data.Respositories;
    public class PacienteRepository : IPacienteRepository
{
    private readonly SADbContext _context;

    public PacienteRepository(SADbContext context)
    {
        _context = context;
    }


    public async Task<IEnumerable<Paciente>> GetAllAsync() =>
        await _context.Pacientes.AsNoTracking().ToListAsync();


    public async Task<Paciente?> GetAsync(int id)
    {
        var paciente = await _context.Pacientes.FindAsync(id); 

        if(paciente is null)
            return null;
        return paciente;
    }

    public async Task<object> PostAsync(Paciente paciente)
    {
        _context.Add(paciente);
        await _context.SaveChangesAsync();
        return paciente.Id;
    }
}
