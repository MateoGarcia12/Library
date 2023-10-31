using System;
using System.Collections.Generic;

namespace libreria.Models;

public partial class Cart
{
    public int IdCart { get; set; }

    public int UsersUserId { get; set; }

    public virtual ICollection<Sale> Sales { get; set; } = new List<Sale>();

    public virtual User UsersUser { get; set; } = null!;

    public virtual ICollection<Book> BooksBooks { get; set; } = new List<Book>();
}
