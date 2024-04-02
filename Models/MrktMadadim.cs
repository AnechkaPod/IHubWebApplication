using System;
using System.Collections.Generic;

namespace IHubWebApplication.Models;

public partial class MrktMadadim
{
    public int Id { get; set; }

    public string SecurityIdentifier { get; set; } = null!;

    public string? KodNeches { get; set; }
}
