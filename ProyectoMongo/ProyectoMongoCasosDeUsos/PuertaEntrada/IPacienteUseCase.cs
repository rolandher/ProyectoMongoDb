using ProyectoMongoEntidades.Comandos;
using ProyectoMongoEntidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoMongoCasosDeUsos.PuertaEntrada
{
    public interface IPacienteUseCase
    {
        Task<Paciente> AgregarPaciente(Paciente paciente);
        Task<List<Paciente>> ObtenerListaPacientes();
        Task<Paciente> ActualizarPaciente(ActualizarPaciente actualizarPaciente, string id);
        Task<Paciente> EliminarPaciente(string id);
    }
}
