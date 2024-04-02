using System;
using System.Collections.Generic;

namespace IHubWebApplication.Models;

public partial class VHmrtCheshbon
{
    public int? KodMetafel { get; set; }

    public string? Metafel { get; set; }

    public int? Id { get; set; }

    public string KodCheshbon { get; set; } = null!;

    public string TeurCheshbon { get; set; } = null!;

    public short KodBank { get; set; }

    public short? Snif { get; set; }

    public string? KodCheshbonNiarot { get; set; }

    public string? KodCheshbonMatach { get; set; }

    public string? KodCheshbonShekel { get; set; }

    public string? MisparTik { get; set; }

    public int? KodMutzar { get; set; }

    public int? KodOtzar { get; set; }

    public int? KodKvutzatTikim { get; set; }
}
