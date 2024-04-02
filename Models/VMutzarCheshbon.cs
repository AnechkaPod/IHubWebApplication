using System;
using System.Collections.Generic;

namespace IHubWebApplication.Models;

public partial class VMutzarCheshbon
{
    public int KodMutzar { get; set; }

    public string? KodCheshbonNiarot { get; set; }

    public string? KodCheshbonMatach { get; set; }

    public string? KodCheshbonShekel { get; set; }

    public string? NameForTri { get; set; }

    public int Id { get; set; }
}
