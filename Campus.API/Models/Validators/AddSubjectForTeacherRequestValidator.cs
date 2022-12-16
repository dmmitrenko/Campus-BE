using Campus.API.Models.Requests;
using FluentValidation;

namespace Campus.API.Models.Validators;

public class AddSubjectForTeacherRequestValidator : AbstractValidator<AddSubjectForTeacherRequest>
{
    public AddSubjectForTeacherRequestValidator()
    {
        RuleFor(x => x.TeacherId).NotEmpty();
        RuleFor(x => x.LessonId).NotEmpty();
    }
}
