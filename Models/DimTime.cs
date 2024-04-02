using System;
using System.Collections.Generic;

namespace IHubWebApplication.Models;

public partial class DimTime
{
    public DateTime TaarichId { get; set; }

    public string Yom { get; set; } = null!;

    public string Chodesh { get; set; } = null!;

    public string Rivon { get; set; } = null!;

    public string Shana { get; set; } = null!;
}
