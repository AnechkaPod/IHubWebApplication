using System;
using System.Collections.Generic;

namespace IHubWebApplication.Models;

public partial class VTnuotBankLeumiMatach
{
    public string KodNeches { get; set; } = null!;

    public short? KodBasisHatzmada { get; set; }

    public DateTime? Taarich { get; set; }

    public short? KodTnuoa { get; set; }

    public int סוגפעולה { get; set; }

    public string מטבעחובה { get; set; } = null!;

    public string שםהחשבון { get; set; } = null!;

    public int סוגחשבוןחובה { get; set; }

    public string? מספרחשבוןחובה { get; set; }

    public short? סניףחובה { get; set; }

    public string? תערךחובה { get; set; }

    public decimal? סכום { get; set; }

    public string מטבעזכות { get; set; } = null!;

    public string מהותפעולה { get; set; } = null!;

    public int סוגחשבוןזכות { get; set; }

    public string? מספרחשבוןזכות { get; set; }

    public short? סניףזכות { get; set; }

    public string אסמכתא { get; set; } = null!;

    public string? תערךזכות { get; set; }

    public string חשבון { get; set; } = null!;

    public string סניף { get; set; } = null!;

    public string העברתמטחללקוחאחר { get; set; } = null!;

    public string בוצעלאבוצע { get; set; } = null!;

    public string הערותרובוט { get; set; } = null!;

    public string יוםעסקים { get; set; } = null!;

    public string התחלה { get; set; } = null!;

    public string סיום { get; set; } = null!;

    public string מסעובד { get; set; } = null!;
}
