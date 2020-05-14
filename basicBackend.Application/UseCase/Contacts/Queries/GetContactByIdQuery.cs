using basicBackend.Application.UseCase.Contacts.Dto;
using MediatR;

namespace basicBackend.Application.UseCase.Contacts.Queries
{
    public class GetContactByIdQuery : IRequest<ContactDTO>
    {
        public int Id { get; set; }
    }
}