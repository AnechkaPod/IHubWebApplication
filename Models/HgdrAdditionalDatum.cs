using System;
using System.Collections.Generic;

namespace IHubWebApplication.Models;

public partial class HgdrAdditionalDatum
{
    public int KodSugYeshut { get; set; }

    public string KodYeshut { get; set; } = null!;

    public int ColumnId { get; set; }

    public int? ValueId { get; set; }

    public string? ValueString { get; set; }

    public decimal? ValueInt { get; set; }

    public DateTime? ValueDate { get; set; }

    public virtual HgdrAdditionalColumnName Column { get; set; } = null!;

    public virtual HgdrAdditionalDataSugYeshut KodSugYeshutNavigation { get; set; } = null!;
}
