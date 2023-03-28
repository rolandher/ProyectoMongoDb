using MongoDB.Driver;
using ProyectoMongoInfraestructura.EntidadesMongo;
using ProyectoMongoInfraestructura.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoMongoInfraestructura
{
    public class Context : IContext
    {
        private readonly IMongoDatabase _database;

        public Context(string stringConnection, string DBname)
        {
            MongoClient cliente = new MongoClient(stringConnection);
            _database = cliente.GetDatabase(DBname);
        }

        public IMongoCollection<EntidadPaciente> Pacientes => _database.GetCollection<EntidadPaciente>("pacientes");
    }
}
