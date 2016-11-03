using Microsoft.AspNetCore.Mvc;
using GrupparbeteMVC2.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace GrupparbeteMVC2.Controllers
{
    public class CustomersController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            var allCustomers = DataManager.GetAllCustomers();
            ViewBag.Customers = allCustomers;
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Customer customer)
        {
            DataManager.AddCustomer(customer);
            return RedirectToAction(nameof(CustomersController.Index));
        }
    }
}
