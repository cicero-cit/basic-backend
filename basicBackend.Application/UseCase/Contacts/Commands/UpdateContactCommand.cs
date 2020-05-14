using MediatR;

namespace basicBackend.Application.UseCase.Contacts.Commands
{
    public class UpdateContactCommand : IRequest<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Nickname { get; set; }
        public int Emoji { get; set; }
    }
}