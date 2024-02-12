using Microsoft.EntityFrameworkCore;

namespace _2211_Assignment_2_Full_Stack_CRUD.Models
{
    public class ContactContext : DbContext
    {
        public ContactContext(DbContextOptions<ContactContext> options)
            : base(options)
        { }

        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(
            ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, CategoryName = "Friend" },
                new Category { CategoryId = 2, CategoryName = "Boss" },
                new Category { CategoryId = 3, CategoryName = "Co-Worker" },
                new Category { CategoryId = 4, CategoryName = "Subordinate" },
                new Category { CategoryId = 5, CategoryName = "Family" },
                new Category { CategoryId = 6, CategoryName = "Acquaintance" },
                new Category { CategoryId = 7, CategoryName = "Enemy" }
            );

            modelBuilder.Entity<Contact>().HasData(
            new Contact
            {
                ContactId = 1,
                FirstName = "Test FirstName",
                LastName = "Test LastName",
                Email = "Test Email",
                Phone = 1111111,
                Organization = "Test Organization",
                CategoryId = 1
            },
            new Contact
            {
                ContactId = 2,
                FirstName = "Test FirstName",
                LastName = "Test LastName",
                Email = "Test Email",
                Phone = 2222222,
                Organization = "Test Organization",
                CategoryId = 2
            },
            new Contact
            {
                ContactId = 3,
                FirstName = "Test FirstName",
                LastName = "Test LastName",
                Email = "Test Email",
                Phone = 3333333,
                Organization = "Test Organization",
                CategoryId = 3
            });
        }
    }
}
