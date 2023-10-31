using System;
using System.Collections.Generic;

namespace libreria.Models;

public partial class Tag
{
    public string TagId { get; set; } = null!;

    public virtual ICollection<Book> BooksBooks { get; set; } = new List<Book>();
}
