using MediatR;

namespace basicBackend.Application.UseCase.Contacts.Commands
{
    public class CreateContactCommand : IRequest<int>
    {
        public string Name { get; set; }
        public string Nickname { get; set; }
        public int Emoji { get; set; }
    }
}