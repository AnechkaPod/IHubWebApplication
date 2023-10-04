using System;
using System.Collections.Generic;

namespace IHubWebApplication.Models;

public partial class Map
{
    public string Field { get; set; } = null!;

    public string? HeaderName { get; set; }

    public string? Type { get; set; }

    public string TableName { get; set; } = null!;

    public int? SortKey { get; set; }
}
