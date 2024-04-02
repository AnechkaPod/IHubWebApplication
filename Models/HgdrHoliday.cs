using System;
using System.Collections.Generic;

namespace IHubWebApplication.Models;

public partial class HgdrHoliday
{
    public DateTime Date { get; set; }

    public string HolidayName { get; set; } = null!;

    public int Country { get; set; }

    public virtual HgdrMedina CountryNavigation { get; set; } = null!;
}
