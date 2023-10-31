using System;
using System.Collections.Generic;

namespace libreria.Models;

public partial class Book
{
    public int BookId { get; set; }

    public string Title { get; set; } = null!;

    public string Description { get; set; } = null!;

    public DateTime PublishedOn { get; set; }

    public string Publisher { get; set; } = null!;

    public decimal Price { get; set; }

    public string ImageUrl { get; set; } = null!;

    public virtual ICollection<Bookauthor> Bookauthors { get; set; } = new List<Bookauthor>();

    public virtual Priceoffer? Priceoffer { get; set; }

    public virtual ICollection<Review> Reviews { get; set; } = new List<Review>();

    public virtual ICollection<Cart> CartIdCarts { get; set; } = new List<Cart>();

    public virtual ICollection<Tag> TagsTags { get; set; } = new List<Tag>();
}
