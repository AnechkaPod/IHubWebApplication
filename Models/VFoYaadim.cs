using System;
using System.Collections.Generic;

namespace IHubWebApplication.Models;

public partial class VFoYaadim
{
    public int KodMutzarCategory { get; set; }

    public string TeurCategory { get; set; } = null!;

    public int KodMutzar { get; set; }

    public int IdMadad { get; set; }

    public decimal? YaadChasifaCatagory { get; set; }

    public decimal? YaadChasifaMutzar { get; set; }

    public decimal? YaadChasifa { get; set; }
}
