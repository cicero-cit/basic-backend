using FluentValidation;
using basicBackend.Application.UseCase.Contacts.Commands;

namespace basicBackend.Application.UseCase.Contacts.Validators
{
    public class CreateContactCommandValidator : AbstractValidator<CreateContactCommand>
    {
        public CreateContactCommandValidator()
        {
            RuleFor(t => t.Name).NotEmpty();
            RuleFor(t => t.Nickname).NotEmpty();
            RuleFor(t => t.Emoji).NotNull();
        }
    }
}