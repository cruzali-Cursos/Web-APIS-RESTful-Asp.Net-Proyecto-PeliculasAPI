using AutoMapper;
using PeliculasAPI.DTOs;
using PeliculasAPI.Entidades;

namespace PeliculasAPI.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Genero, GeneroDTO>().ReverseMap();
            CreateMap<GeneroCreacionDTO, Genero>();

            // Se configura aqui el mapeo de Actor hacia ActorDTO. Se usa ReverseMap porque también
            // se cambiará desde ActorDTO hacia Actor.
            CreateMap<Actor, ActorDTO>().ReverseMap();

            // Se mapea desde ActorCreacionDTO hacia Actor
            CreateMap<ActorCreacionDTO, Actor>();
        }
        
    }
}
