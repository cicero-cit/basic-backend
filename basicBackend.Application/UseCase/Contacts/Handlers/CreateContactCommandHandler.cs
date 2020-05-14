using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using basicBackend.Application.Interfaces;
using basicBackend.Application.UseCase.Contacts.Commands;

namespace basicBackend.Application.UseCase.Contacts.Handlers
{
    public class CreateContactCommandHandler : IRequestHandler<CreateContactCommand, int>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CreateContactCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<int> Handle(CreateContactCommand request, CancellationToken cancellationToken)
        {
            var result = await _unitOfWork.Contacts.Add(_mapper.Map<basicBackend.Core.Entities.Contact>(request));
            return result;
        }
    }
}