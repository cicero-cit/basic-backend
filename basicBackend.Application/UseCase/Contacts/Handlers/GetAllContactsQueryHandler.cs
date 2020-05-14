using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using basicBackend.Application.Interfaces;
using basicBackend.Application.UseCase.Contacts.Dto;
using basicBackend.Application.UseCase.Contacts.Queries;

namespace basicBackend.Application.UseCase.Contacts.Handlers
{
    public class GetAllContactsQueryHandler : IRequestHandler<GetAllContactsQuery, List<ContactDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetAllContactsQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<List<ContactDTO>> Handle(GetAllContactsQuery request, CancellationToken cancellationToken)
        {
            var result = await _unitOfWork.Contacts.GetAll();
            return _mapper.Map<List<ContactDTO>>(result.ToList());
        }
    }
}