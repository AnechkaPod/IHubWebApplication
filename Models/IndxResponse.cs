using System;
using System.Collections.Generic;

namespace IHubWebApplication.Models;

public partial class IndxResponse
{
    public DateTime Date { get; set; }

    public string Data { get; set; } = null!;

    public int Id { get; set; }

    public string ReportType { get; set; } = null!;
}
