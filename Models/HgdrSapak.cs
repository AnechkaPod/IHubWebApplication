using System;
using System.Collections.Generic;

namespace IHubWebApplication.Models;

public partial class HgdrSapak
{
    public int Id { get; set; }

    public string TeurSapak { get; set; } = null!;

    public string? SugSherut { get; set; }

    public virtual ICollection<TnutTnuot> TnutTnuots { get; set; } = new List<TnutTnuot>();
}
