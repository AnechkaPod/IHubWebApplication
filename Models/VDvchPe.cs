using System;
using System.Collections.Generic;

namespace IHubWebApplication.Models;

public partial class VDvchPe
{
    public int? מספרקופהקרןחפעבורחברתביטוח { get; set; }

    public int? מספרמסלול { get; set; }

    public string? שםשותףכלליקרןהשקעות { get; set; }

    public string? מספרמזההשותףכלליקרןהשקעות { get; set; }

    public string? סוגמספרמזההשותףכלליקרןהשקעות { get; set; }

    public string? שםקרןהשקעה { get; set; }

    public string מספרמזההקרןהשקעה { get; set; } = null!;

    public string סוגמספרמזההקרןהשקעות { get; set; } = null!;

    public string? מאפייןעיקרי { get; set; }

    public string? אסטרטגייתקרןההשקעה { get; set; }

    public string ישראלחול { get; set; } = null!;

    public string? מדינתהתאגדותקרןהשקעה { get; set; }

    public string? מיקוםמשרדהשותףהכללי { get; set; }

    public string? מדינהלפיחשיפהכלכלית { get; set; }

    public string בעלענייןצדקשור { get; set; } = null!;

    public string? תאריךרכישה { get; set; }

    public string? מטבעפעילות { get; set; }

    public string? סוגגורםמשערך { get; set; }

    public string תלותאיתלותהמשערך { get; set; } = null!;

    public string? תאריךשערוךאחרון { get; set; }

    public decimal? שערחליפין { get; set; }

    public decimal? Navבמטבעהדיווחשלקרןההשקעה { get; set; }

    public decimal? שוויהוגןבשח { get; set; }

    public string? שיעורהחזקהבקרןהשקעה { get; set; }

    public string? שיעורמנכסיאפיקההשקעה { get; set; }

    public string? שיעורמסךנכסיההשקעה { get; set; }
}
