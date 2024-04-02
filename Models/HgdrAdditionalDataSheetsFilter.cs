using System;
using System.Collections.Generic;

namespace IHubWebApplication.Models;

public partial class HgdrAdditionalDataSheetsFilter
{
    public int SheetId { get; set; }

    public string SheetName { get; set; } = null!;

    public int KodMachshir { get; set; }
}
