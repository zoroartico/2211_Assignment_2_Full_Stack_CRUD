using Microsoft.Build.Framework;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace _2211_Assignment_2_Full_Stack_CRUD.Models
{
    //primary class of this application, creates Contact objects
    public class Contact
    {
        //autosets DateAdded using constructor
        public Contact(){DateAdded = DateTime.Now;}

        //Basic Contact Object containing key elements of a Contact
        public int ContactId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //uses regex to check for characters before and after an @, then checks for period and 2 or more chars.
        [RegularExpression(@"^[a-zA-Z0-9._%+\-]+@[a-zA-Z0-9.\-]+\.[a-zA-Z]{2,}$",ErrorMessage = "The Email field is invalid. Correct format is example@email.com")]
        public string Email { get; set; }

        //uses regex to enforce consistency
        [RegularExpression(@"^\(\d{3}\) \d{3}-\d{4}$", ErrorMessage = "The Phone field is invalid. Must be 10 digits")]
        public string Phone { get; set; }
        public string? Business { get; set; }
        
        //Category Fk
        public int CategoryId {  get; set; }
        public Category? Category { get; set; }

        //Automatic set by constructor
        public DateTime DateAdded { get; set; }

        //Slug for url readability, replaces whitespace with hyphens for standard url convention
        public string Slug =>
            FirstName?.Replace(' ', '-').ToLower() + '-' +
            LastName?.ToString();
    }
    
}
