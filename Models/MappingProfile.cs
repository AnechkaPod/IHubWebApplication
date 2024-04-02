using System;
using System.Collections.Generic;

namespace IHubWebApplication.Models;

public partial class MappingProfile
{
    public int MappingProfileId { get; set; }

    public string? MappingProfileName { get; set; }

    public string? TableTypeName { get; set; }

    public virtual ICollection<Map> Maps { get; set; } = new List<Map>();
}
