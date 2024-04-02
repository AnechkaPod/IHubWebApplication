using System;
using System.Collections.Generic;

namespace IHubWebApplication.Models;

public partial class HgdrSourceSystem
{
    public int Id { get; set; }

    public string Source { get; set; } = null!;

    public string Type { get; set; } = null!;

    public virtual ICollection<BsAllShearim> BsAllShearims { get; set; } = new List<BsAllShearim>();
}
