using SisAgenda.Domain.Entities;

namespace SisAgenda.Domain.Interfaces.Repositories
{
    public interface IPacienteRepository
    {
        Task<IEnumerable<Paciente>> GetAllAsync();
        Task<Paciente?> GetAsync(int id);
        Task<object> PostAsync(Paciente paciente);
    }
}
