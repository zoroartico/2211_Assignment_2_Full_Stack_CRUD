using Microsoft.AspNetCore.Mvc;
using _2211_Assignment_2_Full_Stack_CRUD.Models;

namespace ContactList.Controllers
{
    public class ContactController : Controller
    {
        private ContactContext context { get; set; }
        public ContactController(ContactContext ctx)
        {
            context = ctx;
        }

        //Simple GET and POST Action Methods for all Contact Views
        //Brings Categories as ordered list for dropdown selection on Create & Update Operations
        [HttpGet]
        public IActionResult Add() 
        {
            ViewBag.Action = "Add";
            ViewBag.Categories =
                context
                .Categories
                .OrderBy(c => c.CategoryName)
                .ToList();
            return View("Edit", new Contact());
        }
        [HttpGet]
        public IActionResult Details(int id)
        {
            ViewBag.Action = "Details";
            ViewBag.Categories =
                context
                .Categories
                .OrderBy(c => c.CategoryName)
                .ToList();
            var contact = context.Contacts.Find(id);
            return View(contact);
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";
            ViewBag.Categories =
                context
                .Categories
                .OrderBy(c => c.CategoryName)
                .ToList();
            var contact = context.Contacts.Find(id);
            return View(contact);
        }
        [HttpPost]
        public IActionResult Edit(Contact contact)
        {
            if (ModelState.IsValid)
            {
                if (contact.ContactId == 0)
                    context.Contacts.Add(contact);
                else
                    context.Contacts.Update(contact);
                context.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.Action =
                (contact.ContactId == 0) ? "Add" : "Edit";
                ViewBag.Categories =
                    context
                    .Categories
                    .OrderBy(c => c.CategoryName)
                    .ToList();
                return View(contact);
            }
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var contact = context.Contacts.Find(id);
            return View(contact);
        }
        [HttpPost]
        public IActionResult Delete(Contact contact)
        {
            context.Contacts.Remove(contact);
            context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
    }
}