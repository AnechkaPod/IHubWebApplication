using System;
using System.Collections.Generic;

namespace IHubWebApplication.Model;

public partial class HgdrKarteset
{
    public int Id { get; set; }

    public int KodKarteset { get; set; }

    public string TeurKarteset { get; set; } = null!;

    public int DanelKodPratim { get; set; }

    public virtual ICollection<TnutTnuot> TnutTnuots { get; set; } = new List<TnutTnuot>();
}
