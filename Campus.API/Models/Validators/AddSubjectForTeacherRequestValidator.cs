using Campus.API.Models.Requests;
using FluentValidation;

namespace Campus.API.Models.Validators;

public class AddSubjectForTeacherRequestValidator : AbstractValidator<AddCourseForEducatorRequest>
{
    public AddSubjectForTeacherRequestValidator()
    {
        RuleFor(x => x.TeacherId).NotEmpty();
        RuleFor(x => x.LessonId).NotEmpty();
    }
}
