
namespace SisAgenda.Domain.Entities
{
    public class Paciente
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public string CNS { get; private set; }
        public bool Status { get; private set; }

        public Paciente()
        {
            Status = true;
        }
        public Paciente(string nome, string cNS) : this()
        {
            Nome = nome;
            CNS = cNS;
        }

        public Paciente(int id, string nome, string cNS)
        {
            Id = id;
            Nome = nome;
            CNS = cNS;
        }

        public void DesativarPaciente()
        {
            Status = false;
        }
        public void AtivarPaciente()
        {
            Status = true;
        }

    }
}
