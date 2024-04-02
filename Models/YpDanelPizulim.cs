using System;
using System.Collections.Generic;

namespace IHubWebApplication.Models;

public partial class YpDanelPizulim
{
    public int MisparNiar { get; set; }

    public byte KodBank { get; set; }

    public bool KodTnua { get; set; }

    public DateTime Taarich { get; set; }

    public int Kamut { get; set; }

    public decimal Shaar { get; set; }

    public decimal Shovi { get; set; }
}
