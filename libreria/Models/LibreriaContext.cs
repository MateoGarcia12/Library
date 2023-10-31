using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace libreria.Models;

public partial class LibreriaContext : DbContext
{
    public LibreriaContext()
    {
    }

    public LibreriaContext(DbContextOptions<LibreriaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Author> Authors { get; set; }

    public virtual DbSet<Book> Books { get; set; }

    public virtual DbSet<Bookauthor> Bookauthors { get; set; }

    public virtual DbSet<Cart> Carts { get; set; }

    public virtual DbSet<Efmigrationshistory> Efmigrationshistories { get; set; }

    public virtual DbSet<Priceoffer> Priceoffers { get; set; }

    public virtual DbSet<Review> Reviews { get; set; }

    public virtual DbSet<Sale> Sales { get; set; }

    public virtual DbSet<Tag> Tags { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySql("server=localhost;port=3306;database=libreria;user=root", Microsoft.EntityFrameworkCore.ServerVersion.Parse("10.4.28-mariadb"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8_general_ci")
            .HasCharSet("utf8");

        modelBuilder.Entity<Author>(entity =>
        {
            entity.HasKey(e => e.AuthorId).HasName("PRIMARY");

            entity.ToTable("authors");

            entity.Property(e => e.AuthorId).HasColumnType("int(11)");
        });

        modelBuilder.Entity<Book>(entity =>
        {
            entity.HasKey(e => e.BookId).HasName("PRIMARY");

            entity.ToTable("books");

            entity.Property(e => e.BookId).HasColumnType("int(11)");
            entity.Property(e => e.PublishedOn).HasMaxLength(6);

            entity.HasMany(d => d.CartIdCarts).WithMany(p => p.BooksBooks)
                .UsingEntity<Dictionary<string, object>>(
                    "BooksHasCart",
                    r => r.HasOne<Cart>().WithMany()
                        .HasForeignKey("CartIdCart")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("fk_Books_has_Cart_Cart1"),
                    l => l.HasOne<Book>().WithMany()
                        .HasForeignKey("BooksBookId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("fk_Books_has_Cart_Books1"),
                    j =>
                    {
                        j.HasKey("BooksBookId", "CartIdCart")
                            .HasName("PRIMARY")
                            .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                        j
                            .ToTable("books_has_cart")
                            .HasCharSet("utf8mb4")
                            .UseCollation("utf8mb4_unicode_ci");
                        j.HasIndex(new[] { "BooksBookId" }, "fk_Books_has_Cart_Books1_idx");
                        j.HasIndex(new[] { "CartIdCart" }, "fk_Books_has_Cart_Cart1_idx");
                        j.IndexerProperty<int>("BooksBookId")
                            .HasColumnType("int(11)")
                            .HasColumnName("Books_BookId");
                        j.IndexerProperty<int>("CartIdCart")
                            .HasColumnType("int(11)")
                            .HasColumnName("Cart_idCart");
                    });

            entity.HasMany(d => d.TagsTags).WithMany(p => p.BooksBooks)
                .UsingEntity<Dictionary<string, object>>(
                    "Booktag",
                    r => r.HasOne<Tag>().WithMany()
                        .HasForeignKey("TagsTagId")
                        .HasConstraintName("FK_BookTag_Tags_TagsTagId"),
                    l => l.HasOne<Book>().WithMany()
                        .HasForeignKey("BooksBookId")
                        .HasConstraintName("FK_BookTag_Books_BooksBookId"),
                    j =>
                    {
                        j.HasKey("BooksBookId", "TagsTagId")
                            .HasName("PRIMARY")
                            .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                        j
                            .ToTable("booktag")
                            .HasCharSet("utf8mb4")
                            .UseCollation("utf8mb4_unicode_ci");
                        j.HasIndex(new[] { "TagsTagId" }, "IX_BookTag_TagsTagId");
                        j.IndexerProperty<int>("BooksBookId").HasColumnType("int(11)");
                        j.IndexerProperty<string>("TagsTagId")
                            .UseCollation("utf8_general_ci")
                            .HasCharSet("utf8");
                    });
        });

        modelBuilder.Entity<Bookauthor>(entity =>
        {
            entity.HasKey(e => new { e.BookId, e.AuthorId })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .ToTable("bookauthor")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.AuthorId, "IX_BookAuthor_AuthorId");

            entity.Property(e => e.BookId).HasColumnType("int(11)");
            entity.Property(e => e.AuthorId).HasColumnType("int(11)");
            entity.Property(e => e.Order).HasColumnType("tinyint(3) unsigned");

            entity.HasOne(d => d.Author).WithMany(p => p.Bookauthors)
                .HasForeignKey(d => d.AuthorId)
                .HasConstraintName("FK_BookAuthor_Authors_AuthorId");

            entity.HasOne(d => d.Book).WithMany(p => p.Bookauthors)
                .HasForeignKey(d => d.BookId)
                .HasConstraintName("FK_BookAuthor_Books_BookId");
        });

        modelBuilder.Entity<Cart>(entity =>
        {
            entity.HasKey(e => e.IdCart).HasName("PRIMARY");

            entity.ToTable("cart");

            entity.HasIndex(e => e.UsersUserId, "fk_Cart_Users1_idx");

            entity.Property(e => e.IdCart)
                .HasColumnType("int(11)")
                .HasColumnName("idCart");
            entity.Property(e => e.UsersUserId)
                .HasColumnType("int(11)")
                .HasColumnName("Users_UserId");

            entity.HasOne(d => d.UsersUser).WithMany(p => p.Carts)
                .HasForeignKey(d => d.UsersUserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_Cart_Users1");
        });

        modelBuilder.Entity<Efmigrationshistory>(entity =>
        {
            entity.HasKey(e => e.MigrationId).HasName("PRIMARY");

            entity.ToTable("__efmigrationshistory");

            entity.Property(e => e.MigrationId).HasMaxLength(150);
            entity.Property(e => e.ProductVersion).HasMaxLength(32);
        });

        modelBuilder.Entity<Priceoffer>(entity =>
        {
            entity.HasKey(e => e.PriceOfferId).HasName("PRIMARY");

            entity
                .ToTable("priceoffers")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.BookId, "IX_PriceOffers_BookId").IsUnique();

            entity.Property(e => e.PriceOfferId).HasColumnType("int(11)");
            entity.Property(e => e.BookId).HasColumnType("int(11)");

            entity.HasOne(d => d.Book).WithOne(p => p.Priceoffer)
                .HasForeignKey<Priceoffer>(d => d.BookId)
                .HasConstraintName("FK_PriceOffers_Books_BookId");
        });

        modelBuilder.Entity<Review>(entity =>
        {
            entity.HasKey(e => e.ReviewId).HasName("PRIMARY");

            entity
                .ToTable("review")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.BookId, "IX_Review_BookId");

            entity.Property(e => e.ReviewId).HasColumnType("int(11)");
            entity.Property(e => e.BookId).HasColumnType("int(11)");
            entity.Property(e => e.Comment)
                .UseCollation("utf8_general_ci")
                .HasCharSet("utf8");
            entity.Property(e => e.NumStars).HasColumnType("int(11)");
            entity.Property(e => e.VoterName)
                .UseCollation("utf8_general_ci")
                .HasCharSet("utf8");

            entity.HasOne(d => d.Book).WithMany(p => p.Reviews)
                .HasForeignKey(d => d.BookId)
                .HasConstraintName("FK_Review_Books_BookId");
        });

        modelBuilder.Entity<Sale>(entity =>
        {
            entity.HasKey(e => e.IdSale).HasName("PRIMARY");

            entity.ToTable("sale");

            entity.HasIndex(e => e.CartIdCart, "fk_Sale_Cart1_idx");

            entity.Property(e => e.IdSale)
                .HasColumnType("int(11)")
                .HasColumnName("idSale");
            entity.Property(e => e.CartIdCart)
                .HasColumnType("int(11)")
                .HasColumnName("Cart_idCart");

            entity.HasOne(d => d.CartIdCartNavigation).WithMany(p => p.Sales)
                .HasForeignKey(d => d.CartIdCart)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_Sale_Cart1");
        });

        modelBuilder.Entity<Tag>(entity =>
        {
            entity.HasKey(e => e.TagId).HasName("PRIMARY");

            entity.ToTable("tags");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PRIMARY");

            entity.ToTable("users");

            entity.Property(e => e.UserId).HasColumnType("int(11)");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
