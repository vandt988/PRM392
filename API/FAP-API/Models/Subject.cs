using System;
using System.Collections.Generic;

namespace FAP_API.Models;

public partial class Subject
{
    public string SubjectId { get; set; } = null!;

    public string? SubjectCode { get; set; }

    public string? SubjectName { get; set; }

    public int? IsDelete { get; set; }

    public DateTime? CreateDate { get; set; }

    public virtual ICollection<ExamSchedule> ExamSchedules { get; set; } = new List<ExamSchedule>();
}
