using Microsoft.Build.Framework;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace _2211_Assignment_2_Full_Stack_CRUD.Models
{
    public class Contact
    {
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
        public int CategoryId {  get; set; }
        public Category? Category { get; set; }
        public string Slug =>
            FirstName?.Replace(' ', '-').ToLower() + '-' +
            LastName?.ToString();
    }
}
