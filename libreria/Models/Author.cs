using System;
using System.Collections.Generic;

namespace libreria.Models;

public partial class Author
{
    public int AuthorId { get; set; }

    public string Name { get; set; } = null!;

    public override string ToString()
    {
        return Name; // Return the name of the author for display in CheckedListBox
    }

    public virtual ICollection<Bookauthor> Bookauthors { get; set; } = new List<Bookauthor>();
}
