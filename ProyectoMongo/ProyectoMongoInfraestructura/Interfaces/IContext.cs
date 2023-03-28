using MongoDB.Driver;
using ProyectoMongoInfraestructura.EntidadesMongo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoMongoInfraestructura.Interfaces
{
    public interface IContext
    {
        public IMongoCollection<EntidadPaciente> Pacientes { get; }

    }
}
