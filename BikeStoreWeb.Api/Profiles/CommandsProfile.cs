using AutoMapper;
using BikeStoreWeb.Api.Models;
using BikeStoreWeb.Api.ViewDtos;

namespace BikeStoreWeb.Api.Profiles
{
    public class CommandsProfile : Profile
    {
        public CommandsProfile()
        {
            CreateMap<Command, CommandReadDto>();
            CreateMap<CommandCreateDto, Command>();
        }
    }
}
