using System;
using System.Collections.Generic;

namespace libreria.Models;

public partial class Sale
{
    public int IdSale { get; set; }

    public int CartIdCart { get; set; }

    public virtual Cart CartIdCartNavigation { get; set; } = null!;
}
