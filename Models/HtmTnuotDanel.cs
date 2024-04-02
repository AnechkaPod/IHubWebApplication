using System;
using System.Collections.Generic;

namespace IHubWebApplication.Models;

public partial class HtmTnuotDanel
{
    public int Id { get; set; }

    public string KodNeches { get; set; } = null!;

    public string? Neches { get; set; }

    public int MisparTik { get; set; }

    public decimal? ErechNakuv { get; set; }

    public decimal? Shaar { get; set; }

    public decimal? Shovi { get; set; }

    public short KodPeula { get; set; }

    public DateTime TarichErech { get; set; }

    public int? IdTnouaDanel { get; set; }

    public short? KodMedinaNischeret { get; set; }

    public string? Isin { get; set; }

    public string? Ticker { get; set; }

    public short? Bank { get; set; }

    public string? ShemCheshbon { get; set; }

    public int? Yoez { get; set; }
}
