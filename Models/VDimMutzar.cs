using System;
using System.Collections.Generic;

namespace IHubWebApplication.Models;

public partial class VDimMutzar
{
    public string? SugMutzar { get; set; }

    public int KodMutzar { get; set; }

    public string Mutzar { get; set; } = null!;

    public byte KodSugMutzar { get; set; }

    public bool? IsKerenMechaka { get; set; }

    public string? Medina { get; set; }

    public string? Menahel { get; set; }

    public string? KodCheshbonMatach { get; set; }

    public string? KodCheshbonShekel { get; set; }
}
