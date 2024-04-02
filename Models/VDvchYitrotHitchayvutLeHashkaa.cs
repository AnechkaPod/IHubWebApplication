using System;
using System.Collections.Generic;

namespace IHubWebApplication.Models;

public partial class VDvchYitrotHitchayvutLeHashkaa
{
    public int? מספרקופהקרןחפעבורחברתביטוח { get; set; }

    public int? מספרמסלול { get; set; }

    public string? מאפייןעיקרי { get; set; }

    public string? שםשותףכלליקרןהשקעות { get; set; }

    public string? מספרמזההשותףכלליקרןהשקעות { get; set; }

    public string? סוגמספרמזההשותףכלליקרןהשקעות { get; set; }

    public string? שםקרןהשקעה { get; set; }

    public string מספרמזההקרןהשקעה { get; set; } = null!;

    public string סוגמספרמזההקרןהשקעות { get; set; } = null!;

    public string? מטבעפעילות { get; set; }

    public string? תאריךהעמדתהתחייבותלקרןהשקעה { get; set; }

    public decimal? סכוםהמחויבותהראשוניבמטבעהדיווחשלקרןההשקעה { get; set; }

    public decimal? סכוםהמחויבותהראשוניבשח { get; set; }

    public decimal? יתרתהמחויבותלתקופתהדיווחבמטבעהדיווחשלקרןההשקעה { get; set; }

    public decimal? יתרתהמחויבותלתקופתהדיווחבשח { get; set; }

    public decimal? שיעוריתרתהמחויבות { get; set; }

    public string? תאריךפקיעתמחויבותלהשקעה { get; set; }
}
