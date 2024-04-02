using System;
using System.Collections.Generic;

namespace IHubWebApplication.Models;

public partial class VFoSheariMatbea
{
    public short Id { get; set; }

    public string KodNeches { get; set; } = null!;

    public string KodMatbea { get; set; } = null!;

    public string Matbea { get; set; } = null!;

    public decimal? Shaar { get; set; }

    public decimal? ShaarNbYadani { get; set; }

    public decimal? ShaarKovea { get; set; }
}
