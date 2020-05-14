using AutoMapper;
using basicBackend.Application.UseCase.Contacts.Commands;
using basicBackend.Core.Entities;

namespace basicBackend.Application.UseCase.Contacts.MappingProfiles
{
    public class ContactsMappingProfile : Profile
    {
        public ContactMappingProfile()
        {
            CreateMap<CreateContactCommand, Contact>();
        }
    }
}