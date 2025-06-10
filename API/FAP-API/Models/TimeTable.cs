using System;
using System.Collections.Generic;

namespace FAP_API.Models;

public partial class TimeTable
{
    public string ClassId { get; set; } = null!;

    public string UserId { get; set; } = null!;

    public int IsDelete { get; set; }

    public string SubjectId { get; set; } = null!;

    public string SlotId { get; set; } = null!;

    public string RoomId { get; set; } = null!;

    public int IsAttendance { get; set; }

    public DateOnly DateTime { get; set; }

    public int Semester { get; set; }

    public virtual Class Class { get; set; } = null!;

    public virtual Room Room { get; set; } = null!;

    public virtual Slot Slot { get; set; } = null!;

    public virtual Subject Subject { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
