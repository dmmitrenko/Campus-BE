using Campus.API.Models.Requests;
using FluentValidation;

namespace Campus.API.Models.Validators;

public class AddSubjectRequestValidator : AbstractValidator<AddSubjectRequest>
{
    public AddSubjectRequestValidator()
    {
        RuleFor(x => x.Title).NotEmpty();
    }
}
