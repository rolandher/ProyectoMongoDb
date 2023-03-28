﻿using ProyectoMongoCasosDeUsos.PuertaEntrada.Repositorio;
using ProyectoMongoCasosDeUsos.PuertaEntrada;
using ProyectoMongoEntidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoMongoCasosDeUsos.CasosDeUso
{
    public class PacienteCasoDeUso : IPacienteUseCase
    {
        private readonly IPacienteRepositorio _pacienteRepositorio;

        public PacienteCasoDeUso(IPacienteRepositorio pacienteRepositorio)
        {
            _pacienteRepositorio = pacienteRepositorio;
        }

        public async Task<Paciente> AgregarPaciente(Paciente paciente)
        {
            return await _pacienteRepositorio.AgregarPaciente(paciente);
        }

    }
}