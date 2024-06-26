﻿using System;
using System.Collections.Generic;

namespace IHubWebApplication.Models;

public partial class Mapping
{
    public string Field { get; set; } = null!;

    public string? HeaderName { get; set; }

    public string? Type { get; set; }

    public string TableName { get; set; } = null!;

    public int? SortKey { get; set; }

    public string? ValueOptionsUrl { get; set; }

    public string? OptionsPropertyToDisplay { get; set; }

    public string? FilteringProps { get; set; }

    public bool? IsPrimaryKey { get; set; }

    public string? OptionsPrimaryKey { get; set; }

    public bool? Identity { get; set; }
}
