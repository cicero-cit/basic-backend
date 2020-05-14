using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using basicBackend.Application.UseCase.Contacts.Commands;
using basicBackend.Application.UseCase.Contacts.Dto;
using basicBackend.Application.UseCase.Contacts.Queries;

namespace basicBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactsController : ApiController
    {
        [HttpPost]
        public async Task<ActionResult<int>> Create(CreateContactCommand command)
        {
            return await Mediator.Send(command);
        }

        [HttpGet]
        public async Task<ActionResult<List<ContactDTO>>> GetAll()
        {
            return await Mediator.Send(new GetAllContactsQuery());
        }

        [HttpGet("/{id}")]
        public async Task<ActionResult<ContactDTO>> Get(int id)
        {
            return await Mediator.Send(new GetContactByIdQuery { Id = id });
        }

        [HttpPut]
        public async Task<ActionResult<int>> Update(UpdateContactCommand command)
        {
            return await Mediator.Send(command);
        }

        [HttpDelete]
        public async Task<ActionResult<int>> Delete(int id)
        {
            return await Mediator.Send(new DeleteContactCommand { Id = id });
        }
    }
}