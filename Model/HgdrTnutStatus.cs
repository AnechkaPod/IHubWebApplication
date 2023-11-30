using System;
using System.Collections.Generic;

namespace IHubWebApplication.Model;

public partial class HgdrTnutStatus
{
    public int Id { get; set; }

    public string? Status { get; set; }

    public virtual ICollection<TnutTnuot> TnutTnuots { get; set; } = new List<TnutTnuot>();
}
