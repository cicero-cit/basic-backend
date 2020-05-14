using FluentValidation;
using basicBackend.Application.UseCase.Contacts.Commands;

namespace basicBackend.Application.UseCase.Contacts.Validators
{
    public class UpdateContactCommandValidator : AbstractValidator<UpdateContactCommand>
    {
        public UpdateContactCommandValidator()
        {
            RuleFor(t => t.Name).NotEmpty();
            RuleFor(t => t.Nickname).NotEmpty();
            RuleFor(t => t.Emoji).NotNull();
        }
    }
}