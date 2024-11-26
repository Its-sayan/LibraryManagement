using System;
using System.Collections.Generic;

namespace LibraryManagementSystem.Models;

public partial class Librarian
{
    public int LibrarianId { get; set; }

    public string Name { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string? Role { get; set; }

    public DateOnly? DateJoined { get; set; }
}
