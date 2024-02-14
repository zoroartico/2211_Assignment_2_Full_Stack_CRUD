namespace _2211_Assignment_2_Full_Stack_CRUD.Models
{
    //Standard Convention Error Model
    public class ErrorViewModel
    {
        public string? RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
