using System;
using System.Collections.Generic;

namespace IHubWebApplication.Models;

public partial class VTnuotNoa
{
    public decimal? סכום { get; set; }

    public short? בנק { get; set; }

    public short? סניף { get; set; }

    public string? חשבון { get; set; }

    public string? מוטב { get; set; }

    public string פרטים { get; set; } = null!;

    public string משכורת { get; set; } = null!;

    public int סניףחיוב { get; set; }

    public string? חשבוןחיוב { get; set; }

    public int TnuoaId { get; set; }
}
