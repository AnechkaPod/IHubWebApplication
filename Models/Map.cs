using System;
using System.Collections.Generic;

namespace IHubWebApplication.Models;

public partial class Map
{
    public string? XlsName { get; set; }

    public string? Column { get; set; }

    public int MapId { get; set; }

    public int? MappingProfileId { get; set; }

    public virtual MappingProfile? MappingProfile { get; set; }
}
