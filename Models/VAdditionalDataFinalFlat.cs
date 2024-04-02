using System;
using System.Collections.Generic;

namespace IHubWebApplication.Models;

public partial class VAdditionalDataFinalFlat
{
    public string? KodNeches { get; set; }

    public int? ColumnId { get; set; }

    public string? ColumnName { get; set; }

    public int KodSugYeshut { get; set; }

    public string KodYeshut { get; set; } = null!;

    public string? Value { get; set; }
}
