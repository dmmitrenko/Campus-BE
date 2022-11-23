﻿using System.Xml;

namespace Campus.Subject.Domain.Models;
public class LessonModel
{
    public Guid Id { get; set; }
    public string Title { get; set; }

    public IEnumerable<TeacherLessonsModel> TeacherLessons { get; set; }
    public IEnumerable<TimeTableModel> TimeTables { get; set; }
}
