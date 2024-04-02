using System;
using System.Collections.Generic;

namespace IHubWebApplication.Models;

public partial class VDimMatbea
{
    public short Id { get; set; }

    public string KodNeches { get; set; } = null!;

    public string KodMatbea { get; set; } = null!;

    public string Matbea { get; set; } = null!;

    public byte Rank { get; set; }
}
