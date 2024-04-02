using System;
using System.Collections.Generic;

namespace IHubWebApplication.Models;

public partial class HtmTnuotPitzulim
{
    public int Id { get; set; }

    public int MisparNiar { get; set; }

    public string? Niar { get; set; }

    public int MisparTik { get; set; }

    public byte KodTnua { get; set; }

    public DateTime Taarich { get; set; }

    public double Kamut { get; set; }

    public decimal Shaar { get; set; }

    public decimal Shovi { get; set; }

    public int? IdPitzulDanel { get; set; }

    public short? KodMedinaNischeret { get; set; }

    public string? Isin { get; set; }

    public string? Ticker { get; set; }

    public short? Bank { get; set; }

    public string? ShemHeshbon { get; set; }

    public int? Yoez { get; set; }
}
