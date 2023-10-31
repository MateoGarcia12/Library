using System;
using System.Collections.Generic;

namespace libreria.Models;

public partial class Review
{
    public int ReviewId { get; set; }

    public string VoterName { get; set; } = null!;

    public int NumStars { get; set; }

    public string Comment { get; set; } = null!;

    public int BookId { get; set; }

    public virtual Book Book { get; set; } = null!;
}
