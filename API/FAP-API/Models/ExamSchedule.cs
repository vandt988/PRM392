using System;
using System.Collections.Generic;

namespace FAP_API.Models;

public partial class ExamSchedule
{
    public string EsId { get; set; } = null!;

    public string RoomId { get; set; } = null!;

    public string SubjectId { get; set; } = null!;

    public string SlotId { get; set; } = null!;

    public int? Type { get; set; }

    public int? Note { get; set; }

    public DateOnly? ExamDate { get; set; }

    public int Semester { get; set; }

    public virtual Room Room { get; set; } = null!;

    public virtual Slot Slot { get; set; } = null!;

    public virtual Subject Subject { get; set; } = null!;
}
