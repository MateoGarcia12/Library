using System;
using System.Collections.Generic;

namespace libreria.Models;

public partial class Bookauthor
{
    public int BookId { get; set; }

    public int AuthorId { get; set; }

    public byte Order { get; set; }

    public virtual Author Author { get; set; } = null!;

    public virtual Book Book { get; set; } = null!;
}
