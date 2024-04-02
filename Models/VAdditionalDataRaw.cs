using System;
using System.Collections.Generic;

namespace IHubWebApplication.Models;

public partial class VAdditionalDataRaw
{
    public int KodSugYeshut { get; set; }

    public string KodYeshut { get; set; } = null!;

    public string? ColumnName { get; set; }

    public string? Value { get; set; }

    public int? ColumnId { get; set; }

    public string? KodNeches { get; set; }
}
