using System;
using System.Collections.Generic;

namespace IHubWebApplication.Models;

public partial class DvchReshimatNechasimMipuy
{
    public short IdMachshir { get; set; }

    public int IdSchirut { get; set; }

    public int IdDvchSheet { get; set; }

    public virtual HgdrMachshir IdMachshirNavigation { get; set; } = null!;
}
