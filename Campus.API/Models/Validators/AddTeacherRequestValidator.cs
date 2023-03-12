using Campus.API.Models.Requests;
using FluentValidation;

namespace Campus.API.Models.Validators;

public class AddTeacherRequestValidator : AbstractValidator<AddEducatorRequest>
{
    public AddTeacherRequestValidator()
    {
        RuleFor(x => x.FirstName).Matches(@"^[a-zA-Z]").Length(5, 20).NotEmpty()
            .WithMessage("Only letters! Length: 5 - 20.");
        RuleFor(x => x.MiddleName).Matches(@"^[a-zA-Z]").Length(5, 10)
            .WithMessage("Only letters! Length: 5 - 10.");
        RuleFor(x => x.LastName).Matches(@"^[a-zA-Z]").Length(5, 20).NotEmpty()
            .WithMessage("Only letters! Length: 5 - 10.");
        RuleFor(x => x.Email).EmailAddress();
    }
}
