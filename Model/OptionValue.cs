using System;
using System.Collections.Generic;

namespace IHubWebApplication.Model;

public partial class OptionValue
{
    public string Field { get; set; } = null!;

    public string ValuesTable { get; set; } = null!;

    public int Id { get; set; }

    public string TableName { get; set; } = null!;

    public virtual Map Map { get; set; } = null!;
}
