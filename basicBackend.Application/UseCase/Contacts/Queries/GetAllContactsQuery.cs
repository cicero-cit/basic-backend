using MediatR;
using System.Collections.Generic;
using basicBackend.Application.UseCase.Contacts.Dto;

namespace basicBackend.Application.UseCase.Contacts.Queries
{
    public class GetAllContactsQuery : IRequest<List<ContactDTO>>
    {
    }
}