using System;
using System.Collections.Generic;

namespace IHubWebApplication.Models;

public partial class VTikTsuaHarigMonthly
{
    public int Tik { get; set; }

    public string? TeurTik { get; set; }

    public string Bsc { get; set; } = null!;

    public int? KodMediniyot { get; set; }

    public string? TeurMediniyut { get; set; }

    public int? KodKvutza { get; set; }

    public string? TeurKvutzatTikim { get; set; }

    public DateTime Taarich { get; set; }

    public string? Period { get; set; }

    public decimal? Shovi { get; set; }

    public string? Yoez { get; set; }

    public decimal? Tsua { get; set; }

    public decimal? AvgTsua { get; set; }

    public int Harig { get; set; }

    public string HarigDes { get; set; } = null!;

    public int? EventsCount { get; set; }
}
