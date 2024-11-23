using System;
using System.Collections.Generic;

namespace LibraryManagementSystem.Models;

public partial class Book
{
    public int Id { get; set; }

    public string? Genre { get; set; }

    public string? Title { get; set; }

    public string? Author { get; set; }
}
