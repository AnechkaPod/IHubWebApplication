using System;
using System.Collections.Generic;

namespace IHubWebApplication.Models;

public partial class VDvchNadlan
{
    public int? מספרקופהקרןחפעבורחברתביטוח { get; set; }

    public int? מספרמסלול { get; set; }

    public string? שםהנכס { get; set; }

    public string? מאפייןעיקרי { get; set; }

    public string? מדינתמיקוםנדלן { get; set; }

    public string בעלענייןצדקשור { get; set; } = null!;

    public string? תאריךרכישה { get; set; }

    public string? שימושעיקריבנכס { get; set; }

    public string? מחזורחייהנכס { get; set; }

    public string? כתובתהנכס { get; set; }

    public string? שיעורתשואהבפועלבמהלךהרבעון { get; set; }

    public string? השיטהשבאמצעותהנקבעשוויהנכס { get; set; }

    public string? סוגגורםמשערך { get; set; }

    public string? שםגורםמשערך { get; set; }

    public string תלותאיתלותהמשערך { get; set; } = null!;

    public string? תאריךשערוךאחרון { get; set; }

    public string? מטבעפעילות { get; set; }

    public decimal? שוויהוגןבמטבעהפעילות { get; set; }

    public decimal? שוויהוגןבשח { get; set; }

    public string? עלותמופחתתבשח { get; set; }

    public string? עלותמופחתתבמטבעהפעילות { get; set; }

    public string השיטהשיושמהבדוחהכספי { get; set; } = null!;

    public string? שיעורמנכסיאפיקההשקעה { get; set; }

    public string? שיעורמסךנכסיההשקעה { get; set; }
}
