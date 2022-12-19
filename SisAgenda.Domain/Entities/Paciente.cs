using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisAgenda.Domain.Entities
{
    public class Paciente
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public string CNS { get; private set; }
        public bool Status { get; private set; }

        public Paciente(string nome, string cNS)
        {
            Nome = nome;
            CNS = cNS;
            Status = true;
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
