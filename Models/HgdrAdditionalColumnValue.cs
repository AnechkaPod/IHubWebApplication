using System;
using System.Collections.Generic;

namespace IHubWebApplication.Models;

public partial class HgdrAdditionalColumnValue
{
    public int ValueId { get; set; }

    public int? ColumnId { get; set; }

    public string Value { get; set; } = null!;

    public virtual HgdrAdditionalColumnName? Column { get; set; }
}
