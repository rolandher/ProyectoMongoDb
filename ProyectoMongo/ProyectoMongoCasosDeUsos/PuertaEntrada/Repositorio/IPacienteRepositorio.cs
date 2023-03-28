using ProyectoMongoEntidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoMongoCasosDeUsos.PuertaEntrada.Repositorio
{
    public interface IPacienteRepositorio
    {
        Task<Paciente> AgregarPaciente(Paciente paciente);
    }
}
