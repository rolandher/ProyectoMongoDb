using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ProyectoMongoCasosDeUsos.PuertaEntrada;
using ProyectoMongoEntidades.Comandos;
using ProyectoMongoEntidades.Entidades;

namespace ProyectoMongoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PacienteController : ControllerBase
    {
        private readonly IPacienteUseCase _pacienteUseCase;
        private readonly IMapper _mapper;

        public PacienteController(IPacienteUseCase pacienteUseCase, IMapper mapper)
        {
            _pacienteUseCase = pacienteUseCase;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<Paciente> Registrar_Paciente([FromBody] IngresarPaciente command)
        {
            return await _pacienteUseCase.AgregarPaciente(_mapper.Map<Paciente>(command));
        }
        [HttpGet]
        public async Task<List<Paciente>> ObtenerPacientes()
        {
            return await _pacienteUseCase.ObtenerListaPacientes();
        }
    }
}
