using System;
using System.Collections.Generic;

namespace IHubWebApplication.Models;

public partial class YpDanelTnout
{
    public string MisparNiar { get; set; } = null!;

    public short KodBank { get; set; }

    public DateTime TaarichErech { get; set; }

    public int KodPeula { get; set; }

    public string? KodPeulaBank { get; set; }

    public long? Shovi { get; set; }

    public int? Kamut { get; set; }
}
