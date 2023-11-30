using System;
using System.Collections.Generic;

namespace IHubWebApplication.Model;

public partial class HgdrTnua
{
    public short Id { get; set; }

    public string TeurTnua { get; set; } = null!;

    public bool Direction { get; set; }

    public short? MachpilKamut { get; set; }

    public short? MachpilShovi { get; set; }

    public virtual ICollection<TnutTnuot> TnutTnuots { get; set; } = new List<TnutTnuot>();
}
