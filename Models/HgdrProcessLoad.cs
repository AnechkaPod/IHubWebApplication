using System;
using System.Collections.Generic;

namespace IHubWebApplication.Models;

public partial class HgdrProcessLoad
{
    public int Id { get; set; }

    public string ProcessName { get; set; } = null!;

    public string? ProcessDisplayName { get; set; }

    public short Status { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public bool? MainLoadRel { get; set; }
}
