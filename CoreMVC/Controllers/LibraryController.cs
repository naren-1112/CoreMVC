using CoreMVC.Models;
using CoreMVC.Services;
using Microsoft.AspNetCore.Mvc;

namespace CoreMVC.Controllers
{
    public class LibraryController : Controller
    {
        public static List<Books> books = new List<Books>();
       
        private readonly ICustomer _customers;
        public LibraryController(ICustomer customer)
        {
            _customers = customer;
        }
        [HttpPost]

        public IActionResult Add(Books book)
        {
            if (ModelState.IsValid)
            {
                books.Add(book);
            
                _customers.AddBooks(book);
              //  return CreatedAtAction("AddBooks", new { book.BookID }, book);
                return View();

            }
            return BadRequest();
        }

        [HttpGet]

        public IActionResult GetDetails()
        {
            try
            {
                var Books = _customers.GetBooks();

                if (Books != null)
                    return View(Books);
                
            }

            catch (Exception)
            {
                return View();
            }

            return View();
        }
        [HttpDelete]
        public IActionResult Remove(int BookID)
        {
            bool k = _customers.Delete(BookID);
            if (k)
            {
                return View(k);
            }
            return View();
        }
    }
}
