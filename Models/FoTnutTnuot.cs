using System;
using System.Collections.Generic;

namespace IHubWebApplication.Models;

public partial class FoTnutTnuot
{
    public int Id { get; set; }

    public string Ticker { get; set; } = null!;

    public decimal? ErechNakuv { get; set; }

    public int? Status { get; set; }

    public DateTime? Taarich { get; set; }

    public DateTime? TaarichYitrot { get; set; }

    public int? KodCheshbon { get; set; }

    public short? CounterParty { get; set; }

    public string? User { get; set; }

    public decimal? AchuzHasifaRazoi { get; set; }

    public int? MadadId { get; set; }

    public int? TnuaDeleted { get; set; }

    public bool? IsDeleted { get; set; }

    public TimeSpan? Time { get; set; }

    public decimal? AchuzHasifaRazoiFutures { get; set; }

    public decimal? AchuzHasifaRazoiEtf { get; set; }

    public bool? FlgGilgul { get; set; }
}
