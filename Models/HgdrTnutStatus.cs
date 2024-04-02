using System;
using System.Collections.Generic;

namespace IHubWebApplication.Models;

public partial class HgdrTnutStatus
{
    public int Id { get; set; }

    public string Status { get; set; } = null!;

    public virtual ICollection<TnutTnuot> TnutTnuots { get; set; } = new List<TnutTnuot>();
}
