using System;
using System.Collections.Generic;

namespace IHubWebApplication.Models;

public partial class MrktField
{
    public int Id { get; set; }

    public string FieldId { get; set; } = null!;

    public string? FieldDescription { get; set; }
}
