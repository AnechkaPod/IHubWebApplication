using System;
using System.Collections.Generic;

namespace IHubWebApplication.Models;

public partial class HgdrMedina
{
    public int Id { get; set; }

    public string TeurMedina { get; set; } = null!;

    public int? KodMedinaSnir { get; set; }

    public virtual ICollection<HgdrHoliday> HgdrHolidays { get; set; } = new List<HgdrHoliday>();

    public virtual ICollection<HgdrNech> HgdrNechKodMedinaManpikaNavigations { get; set; } = new List<HgdrNech>();

    public virtual ICollection<HgdrNech> HgdrNechKodMedinaNischeretNavigations { get; set; } = new List<HgdrNech>();

    public virtual ICollection<HgdrNech> HgdrNechKodMedinatChasifaNavigations { get; set; } = new List<HgdrNech>();
}
