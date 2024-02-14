using Microsoft.EntityFrameworkCore;

namespace _2211_Assignment_2_Full_Stack_CRUD.Models
{
    //Pre-defining data for DB
    public class ContactContext : DbContext
    {
        public ContactContext(DbContextOptions<ContactContext> options)
            : base(options)
        { }

        //Table declaration
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Category> Categories { get; set; }

        //Data Population
        protected override void OnModelCreating(
            ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            //Populates Category Table
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, CategoryName = "Friend" },
                new Category { CategoryId = 2, CategoryName = "Boss" },
                new Category { CategoryId = 3, CategoryName = "Co-Worker" },
                new Category { CategoryId = 4, CategoryName = "Employee" },
                new Category { CategoryId = 5, CategoryName = "Family" },
                new Category { CategoryId = 6, CategoryName = "Acquaintance" },
                new Category { CategoryId = 7, CategoryName = "Enemy" }
            );

            //Populates Contacts Table
            modelBuilder.Entity<Contact>().HasData(
            new Contact
            {
                ContactId = 1,
                FirstName = "Kaden",
                LastName = "de Frece",
                Email = "Kadendefrece@RDPolyTech.ca",
                Phone = "(111) 111-1111",
                Business = "Red Deer Polytechnic",
                CategoryId = 1
            },
            new Contact
            {
                ContactId = 2,
                FirstName = "Ryan",
                LastName = "McGrandle",
                Email = "Ryan@GamerMail.com",
                Phone = "(321) 456-7890",
                Business = "Gamers",
                CategoryId = 1
            },
            new Contact
            {
                ContactId = 3,
                FirstName = "Ivan",
                LastName = "Guy",
                Email = "Guy@GuyMail.eu",
                Phone = "(222) 222-2222",
                Business = "School",
                CategoryId = 7
            });
        }
    }
}

