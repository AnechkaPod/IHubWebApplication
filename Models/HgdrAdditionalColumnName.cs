using System;
using System.Collections.Generic;

namespace IHubWebApplication.Models;

public partial class HgdrAdditionalColumnName
{
    public int ColumnId { get; set; }

    public string ColumnName { get; set; } = null!;

    public int? DataType { get; set; }

    public virtual ICollection<HgdrAdditionalColumnValue> HgdrAdditionalColumnValues { get; set; } = new List<HgdrAdditionalColumnValue>();

    public virtual ICollection<HgdrAdditionalDatum> HgdrAdditionalData { get; set; } = new List<HgdrAdditionalDatum>();
}
