using System;
using System.Collections.Generic;

namespace libreria.Models;

public partial class User
{
    public int UserId { get; set; }

    public string UserName { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public bool IsAdmin { get; set; }

    public virtual ICollection<Cart> Carts { get; set; } = new List<Cart>();
}
