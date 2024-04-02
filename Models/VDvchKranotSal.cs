﻿using System;
using System.Collections.Generic;

namespace IHubWebApplication.Models;

public partial class VDvchKranotSal
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

    public string? זירתמסחר { get; set; }

    public string? סיווגהקרן { get; set; }

    public string בעלענייןצדקשור { get; set; } = null!;

    public string? מטבעפעילות { get; set; }

    public decimal? ערךנקוביחידות { get; set; }

    public decimal? שערחליפין { get; set; }

    public decimal? שערניירהערך { get; set; }

    public decimal? שוויהוגןבשח { get; set; }

    public string? שיעורמערךנקובמונפק { get; set; }

    public string? שיעורמנכסיאפיקההשקעה { get; set; }

    public string? שיעורמסךנכסיההשקעה { get; set; }
}
