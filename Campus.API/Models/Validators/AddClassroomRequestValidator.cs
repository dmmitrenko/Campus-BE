using Campus.API.Models.Requests;
using FluentValidation;

namespace Campus.API.Models.Validators;

public class AddClassroomRequestValidator : AbstractValidator<AddClassroomRequest>
{
    public AddClassroomRequestValidator()
    {
        RuleFor(x => x.Title).Matches(@"/^[A-Z]{2}[-][0-9]{2}|[A-Z]{2}[a-z]{1}[-][0-9]{2}")
            .WithMessage("The name of the group should be in the format: PB-91, or PBp-91");
    }
}
