using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using basicBackend.Application.Interfaces;
using basicBackend.Application.UseCase.Contacts.Commands;

namespace basicBackend.Application.Tasks.Handlers
{
    public class UpdateContactCommandHandler : IRequestHandler<UpdateContactCommand, int>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public UpdateContactCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<int> Handle(UpdateContactCommand request, CancellationToken cancellationToken)
        {
            var result = await _unitOfWork.Contacts.Update(_mapper.Map<basicBackend.Core.Entities.Contact>(request));
            return result;
        }
    }
}