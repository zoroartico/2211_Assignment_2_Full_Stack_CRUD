using System.ComponentModel;

namespace _2211_Assignment_2_Full_Stack_CRUD.Models
{
    public class Contact
    {
        public int ContactId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Organization { get; set; }
        public int CategoryId {  get; set; }
        public Category? Category { get; set; }
        public string Slug =>
            FirstName?.Replace(' ', '-').ToLower() + '-' +
            LastName?.ToString();
    }
}
