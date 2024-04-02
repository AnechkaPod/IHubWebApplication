using System;
using System.Collections.Generic;

namespace IHubWebApplication.Models;

public partial class VDvchMisgeretAshrai
{
    public int? מספרקופהקרןחפעבורחברתביטוח { get; set; }

    public int? מספרמסלול { get; set; }

    public int? מספרמזההלווה { get; set; }

    public string סוגמספרמזההלווה { get; set; } = null!;

    public string? שםהלוואה { get; set; }

    public string מספרהלוואה { get; set; } = null!;

    public string? תאריךהעמדתמסגרתאשראי { get; set; }

    public string ישראלחול { get; set; } = null!;

    public string? מדינהלפיחשיפהכלכלית { get; set; }

    public string בעלענייןצדקשור { get; set; } = null!;

    public string? דירוג { get; set; }

    public string? שםמדרג { get; set; }

    public string דירוגהלוואההמנפיק { get; set; } = null!;

    public string? מטבעפעילות { get; set; }

    public decimal? שערחליפין { get; set; }

    public string? שיעורריבית { get; set; }

    public string סוגהריבית { get; set; } = null!;

    public double? סכוםמסגרתהאשראיהראשוניבמטבעהפעילות { get; set; }

    public double? סכוםמסגרתהאשראיהראשוניבשח { get; set; }

    public string? שיעוריתרתמסגרתאשראי { get; set; }
}
