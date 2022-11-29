﻿namespace Campus_Subject.API.Models.Requests;

public record AddSubjectForTeacherRequest
{
    public Guid TeacherId { get; init; }
    public Guid LessonId { get; init; }
}