using System;
using System.Collections.Generic;

namespace IHubWebApplication.Models;

public partial class VTradeDate
{
    public DateTime TaarichId { get; set; }

    public int? KodYom { get; set; }

    public int? SortYom { get; set; }

    public string Yom { get; set; } = null!;

    public int? KodChodesh { get; set; }

    public int? SortChodesh { get; set; }

    public string Chodesh { get; set; } = null!;

    public int? KodShana { get; set; }

    public int? SortShana { get; set; }

    public string Shana { get; set; } = null!;
}
