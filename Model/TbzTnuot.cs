using System;
using System.Collections.Generic;

namespace IHubWebApplication.Model;

public partial class TbzTnuot
{
    public int Id { get; set; }

    public string SecurityId { get; set; } = null!;

    public int AccountId { get; set; }
}
