﻿using System.Data.Entity;

namespace BookStore.Models
{
    public class BookStoreEntities : DbContext {
        public BookStoreEntities() : base("name=BookStoreEntities") { }
        public DbSet<BookStore.Models.Book> Books { get; set; }
        public DbSet<BookStore.Models.Genre> Genres { get; set; }
        public DbSet<BookStore.Models.Author> Authors { get; set; }
    }
}