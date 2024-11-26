using System;
using System.Collections.Generic;

namespace LibraryManagementSystem.Models;

public partial class Member
{
    public int MemberId { get; set; }

    public string Name { get; set; } = null!;

    public string Email { get; set; } = null!;

    public int? Phone { get; set; }

    public DateOnly? MembershipDate { get; set; }

    public string? Status { get; set; }

    public virtual ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();
}
