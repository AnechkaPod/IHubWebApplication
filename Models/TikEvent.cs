using System;
using System.Collections.Generic;

namespace IHubWebApplication.Models;

public partial class TikEvent
{
    public int Tik { get; set; }

    public DateTime Taarich { get; set; }

    public string EventType { get; set; } = null!;

    public string? EventDetailes { get; set; }
}
