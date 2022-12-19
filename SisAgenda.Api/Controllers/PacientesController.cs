using Microsoft.AspNetCore.Mvc;
using SisAgenda.Domain.Entities;
using SisAgenda.Domain.Interfaces.Repositories;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SisAgenda.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PacientesController : ControllerBase
    {
        private readonly IPacienteRepository _pacienteRepository;

        public PacientesController(IPacienteRepository pacienteRepository)
        {
            _pacienteRepository = pacienteRepository;
        }

        // GET: api/<PacientesController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Paciente>>> Get()
        {
            var pacientes = await _pacienteRepository.GetAllAsync();
            return Ok(pacientes);
        }

        // GET api/<PacientesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<PacientesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<PacientesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PacientesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
