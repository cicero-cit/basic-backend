using AutoMapper;
using basicBackend.Application.UseCase.Contacts.Commands;
using basicBackend.Application.UseCase.Contacts.Dto;
using basicBackend.Core.Entities;

namespace basicBackend.Application.UseCase.Contacts.MappingProfiles
{
    public class ContactsMappingProfile : Profile
    {
        public ContactsMappingProfile()
        {
            CreateMap<CreateContactCommand, Contact>();
            CreateMap<UpdateContactCommand, Contact>();
            CreateMap<Contact, ContactDTO>();
        }
    }
}