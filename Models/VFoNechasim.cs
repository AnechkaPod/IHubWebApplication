using System;
using System.Collections.Generic;

namespace IHubWebApplication.Models;

public partial class VFoNechasim
{
    public string? TeurMadad { get; set; }

    public string? Ticker { get; set; }

    public string? Neches { get; set; }

    public string? KodNechesBasis { get; set; }

    public short? KodMachshir { get; set; }

    public decimal Multiplier { get; set; }

    public decimal Shaar { get; set; }

    public decimal? ShaarNbYadani { get; set; }

    public string? Sufix { get; set; }

    public bool? CalcTransFlg { get; set; }

    public bool? NechesIsraeli { get; set; }

    public bool? NechesRashi { get; set; }

    public short? KodMatbea { get; set; }
}
