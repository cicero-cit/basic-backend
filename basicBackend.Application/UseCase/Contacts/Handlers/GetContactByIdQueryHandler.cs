using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using basicBackend.Application.Interfaces;
using basicBackend.Application.UseCase.Contacts.Dto;
using basicBackend.Application.UseCase.Contacts.Queries;

namespace basicBackend.Application.UseCase.Contacts.Handlers
{
    public class GetContactByIdQueryHandler : IRequestHandler<GetContactByIdQuery, ContactDTO>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetContactByIdQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<ContactDTO> Handle(GetContactByIdQuery request, CancellationToken cancellationToken)
        {
            var result = await _unitOfWork.Contacts.Get(request.Id);
            return _mapper.Map<ContactDTO>(result);
        }
    }
}