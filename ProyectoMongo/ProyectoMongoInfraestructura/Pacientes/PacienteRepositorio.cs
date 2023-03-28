using AutoMapper;
using MongoDB.Driver;
using ProyectoMongoCasosDeUsos.PuertaEntrada.Repositorio;
using ProyectoMongoEntidades.Entidades;
using ProyectoMongoInfraestructura.EntidadesMongo;
using ProyectoMongoInfraestructura.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoMongoInfraestructura.Pacientes
{
    public class PacienteRepositorio : IPacienteRepositorio
    {
        private readonly IMongoCollection<EntidadPaciente> _coleccion;
        private readonly IMapper _mapper;

        public PacienteRepositorio(IContext context, IMapper mapper)
        {
            this._coleccion = context.Pacientes;
            _mapper = mapper;
        }

        public async Task<Paciente> AgregarPaciente(Paciente paciente)
        {
            var agregarPaciente = _mapper.Map<EntidadPaciente>(paciente);
            await _coleccion.InsertOneAsync(agregarPaciente);

            if (agregarPaciente == null)
            {
                throw new Exception($"por favor agrege informacion del paciente");
            }
            return paciente;
        }
    }
}