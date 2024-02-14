namespace _2211_Assignment_2_Full_Stack_CRUD.Models
{
    //Standard Convention Error Model Handler
    public class ErrorViewModel
    {
        //gets/sets unique error identifier
        public string? RequestId { get; set; }

        //bool return if RequestId is empty(false) or not-empty(true) 
        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
