using MediatR;
using System.Threading;
using System.Threading.Tasks;
using basicBackend.Application.Interfaces;
using basicBackend.Application.UseCase.Contacts.Commands;

namespace basicBackend.Application.UseCase.Contacts.Handlers
{
    public class DeleteContactCommandHandler : IRequestHandler<DeleteContactCommand, int>
    {
        private readonly IUnitOfWork _unitOfWork;

        public DeleteContactCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<int> Handle(DeleteContactCommand request, CancellationToken cancellationToken)
        {
            var result = await _unitOfWork.Contacts.Delete(request.Id);
            return result;
        }
    }
}