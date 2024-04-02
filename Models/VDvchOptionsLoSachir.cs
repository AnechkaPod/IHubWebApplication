﻿using System;
using System.Collections.Generic;

namespace IHubWebApplication.Models;

public partial class VDvchOptionsLoSachir
{
    public int? מספרקופהקרןחפעבורחברתביטוח { get; set; }

    public int? מספרמסלול { get; set; }

    public string? שםמנפיק { get; set; }

    public int? מספרמנפיק { get; set; }

    public string סוגמספרמזההמנפיק { get; set; } = null!;

    public string? שםניירערך { get; set; }

    public string? מספרניירערך { get; set; }

    public string סוגמספרניירערך { get; set; } = null!;

    public string? מאפייןעיקרי { get; set; }

    public string ישראלחול { get; set; } = null!;

    public string? מדינהלפיחשיפהכלכלית { get; set; }

    public string? ענףמסחר { get; set; }

    public string? נכסבסיס { get; set; }

    public string? תאריךפקיעה { get; set; }

    public string בעלענייןצדקשור { get; set; } = null!;

    public string? תאריךרכישה { get; set; }

    public string? מטבעפעילות { get; set; }

    public string? סוגגורםמשערך { get; set; }

    public string תלותאיתלותהמשערך { get; set; } = null!;

    public string? תאריךשערוךאחרון { get; set; }

    public decimal? שערמימוש { get; set; }

    public decimal? יחסהמרה { get; set; }

    public decimal? ערךנקוביחידות { get; set; }

    public decimal? שערניירהערך { get; set; }

    public decimal? שערחליפין { get; set; }

    public decimal? שוויהוגןבשח { get; set; }

    public string? שיעורמנכסיאפיקההשקעה { get; set; }

    public string? שיעורמסךנכסיההשקעה { get; set; }
}
