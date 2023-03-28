using AutoMapper;

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
