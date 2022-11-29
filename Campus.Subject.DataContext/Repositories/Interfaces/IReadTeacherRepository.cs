﻿using Campus.Subject.DataContext.Entities;
using Campus.Subject.DataContext.Repositories.Base;

namespace Campus.Subject.DataContext.Repositories.Interfaces;
public interface IReadTeacherRepository : IReadRepository<Teacher>
{
    Task<Teacher?> GetTeacherWithSubjects(Guid teacherId);
}
