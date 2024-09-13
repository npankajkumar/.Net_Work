using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVCCoreWebApp.Models;
using MVCCoreWebApp.Repositories;

namespace MVCCoreWebApp.Controllers
{
    public class CustomerController : Controller
    {
        
        public ActionResult Create()
        {
            return View();
        }

        // POST: Customer/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Customer c)
        {
            CustomerRepository.customer.Add(c);
            return RedirectToAction("Index"); ;
        }
        public IActionResult Index()
        {
            return View(CustomerRepository.customer);
        }
        [HttpPost]
        public IActionResult Edit(string id,Customer c)
        {


            return RedirectToAction("Index");

        }

    }
}
