using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using _2211_Assignment_2_Full_Stack_CRUD.Models;
namespace _2211_Assignment_2_Full_Stack_CRUD.Controllers
{
    public class HomeController : Controller
    {
        private ContactContext context { get; set; }
        public HomeController(ContactContext ctx)
        {
            context = ctx;
        }

        //Home Action Methods

        //returns About View
        public IActionResult About()
        {
            return View();
        }

        //Default path index action method returning list of all contacts
        public IActionResult Index()
        {
            var contacts =
                context
                .Contacts.Include(c => c.Category)
                .OrderBy(c => c.FirstName)
                .ToList();
            return View(contacts);
        }
    }
}