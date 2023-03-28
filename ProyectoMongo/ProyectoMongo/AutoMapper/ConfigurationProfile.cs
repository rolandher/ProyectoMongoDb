using AutoMapper;
using ProyectoMongoEntidades.Comandos;
using ProyectoMongoEntidades.Entidades;
using ProyectoMongoInfraestructura.EntidadesMongo;

namespace ProyectoMongoApi.AutoMapper
{
    public class ConfigurationProfile : Profile
    {
        public ConfigurationProfile()
        {
            CreateMap<IngresarPaciente, Paciente>().ReverseMap();

            CreateMap<EntidadPaciente, Paciente>().ReverseMap();
        }
    }
}
