using System;
using System.Collections.Generic;

namespace FAP_API.Models;

public partial class User
{
    public string UserId { get; set; } = null!;

    public string? Email { get; set; }

    public string? Password { get; set; }

    public int? Role { get; set; }

    public string? StudentCode { get; set; }

    public string? FullName { get; set; }

    public string? UserName { get; set; }

    public int? Status { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? UpdateDate { get; set; }

    public bool? IsDelete { get; set; }

    public virtual ICollection<ExamUser> ExamUsers { get; set; } = new List<ExamUser>();

    public virtual ICollection<Letter> Letters { get; set; } = new List<Letter>();
}
