using System;
using System.Collections.Generic;

namespace IHubWebApplication.Models;

public partial class VTnuotStatusLog
{
    public int TnuotId { get; set; }

    public int TnuotStatusId { get; set; }

    public string InsUser { get; set; } = null!;

    public DateTime TimeStamp { get; set; }

    public string Status { get; set; } = null!;
}
