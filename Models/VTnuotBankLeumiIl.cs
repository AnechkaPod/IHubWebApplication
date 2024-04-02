using System;
using System.Collections.Generic;

namespace IHubWebApplication.Models;

public partial class VTnuotBankLeumiIl
{
    public string KodNeches { get; set; } = null!;

    public short? KodBasisHatzmada { get; set; }

    public DateTime? Taarich { get; set; }

    public short? KodTnuoa { get; set; }

    public string? תאריךבפורמטDdmmyy { get; set; }

    public short? בנקחובה { get; set; }

    public short? סניףחובה { get; set; }

    public int סוגחשבוןחובה { get; set; }

    public string? מספרחשבוןחובה { get; set; }

    public short? בנקזכות { get; set; }

    public short? סניףזכות { get; set; }

    public int סוגחשבוןזכות { get; set; }

    public string? מספרחשבוןאומסזהבזכות { get; set; }

    public decimal? סכום { get; set; }

    public string אסמכתא { get; set; } = null!;

    public string? שםהמוטב { get; set; }

    public string? שםהמעביר { get; set; }
}
