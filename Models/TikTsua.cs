using System;
using System.Collections.Generic;

namespace IHubWebApplication.Models;

public partial class TikTsua
{
    public int Tik { get; set; }

    public string? TeurTik { get; set; }

    public string Bsc { get; set; } = null!;

    public DateTime Taarich { get; set; }

    public decimal? Tsua { get; set; }

    public int? KodMediniyot { get; set; }

    public int? KodKvutza { get; set; }

    public string? Period { get; set; }

    public string? Yoez { get; set; }

    public decimal? Shovi { get; set; }
}
