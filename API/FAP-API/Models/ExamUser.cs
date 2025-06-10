using System;
using System.Collections.Generic;

namespace FAP_API.Models;

public partial class ExamUser
{
    public string EsId { get; set; } = null!;

    public string UserId { get; set; } = null!;

    public long? IsTeacher { get; set; }

    public virtual User User { get; set; } = null!;
}
