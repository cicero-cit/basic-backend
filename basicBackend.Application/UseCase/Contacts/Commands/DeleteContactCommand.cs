using MediatR;

namespace basicBackend.Application.UseCase.Contacts.Commands
{
    public class DeleteContactCommand : IRequest<int>
    {
        public int Id { get; set; }
    }
}
