using System;
using System.Collections.Generic;

namespace IHubWebApplication.Models;

public partial class TnutStatusLog
{
    public int TnuotId { get; set; }

    public int TnuotStatusId { get; set; }

    public string InsUser { get; set; } = null!;

    public DateTime TimeStamp { get; set; }

    public virtual TnutTnuot Tnuot { get; set; } = null!;

    public virtual HgdrTnutStatus TnuotStatus { get; set; } = null!;
}
