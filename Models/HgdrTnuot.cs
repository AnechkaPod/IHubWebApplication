using System;
using System.Collections.Generic;

namespace IHubWebApplication.Models;

public partial class HgdrTnuot
{
    public short Id { get; set; }

    public string TeurTnuoa { get; set; } = null!;

    public bool Direction { get; set; }

    public short? MachpilKamut { get; set; }

    public short? MachpilShovi { get; set; }

    public short? MachpilOsh { get; set; }

    public short? MachpilMas { get; set; }

    public short? MachpilRibit { get; set; }

    public short? MachpilAmlaKniyaMechira { get; set; }

    public int? KodTnuaSdm { get; set; }

    public int? KodPeulaDanel { get; set; }

    public int? KodTnuoaDanel { get; set; }

    public int? KodPratimDanel { get; set; }

    public virtual ICollection<TnutTnuot> TnutTnuots { get; set; } = new List<TnutTnuot>();
}
