﻿using Campus.Subject.DataContext.Entities;
using Campus.Subject.DataContext.Repositories.Base;
using Campus.Subject.DataContext.Repositories.Interfaces;
using Microsoft.Extensions.Logging;

namespace Campus.Subject.DataContext.Repositories.Implementations;
public class WriteTeacherRepository : WriteRepository<Teacher>, IWriteTeacherRepository
{
    public WriteTeacherRepository(
        ILogger logger, 
        CampusDbContext context) : base(logger, context)
    {
    }
}
