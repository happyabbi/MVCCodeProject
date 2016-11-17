using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;


namespace WebApplication2.Controllers
{

    public class Customer
    {
        public string CustomerName { get; set; }
        public string Address { get; set; }

        public override string ToString()
        {
            return this.CustomerName + "|" + this.Address;
        }
    }


    public class TestController : Controller
    {
        public string GetString()
        {
            return "Hello World is old now. It's time for wassup bro;";
        }

        public Customer GetCustomer()
        {
            Customer c = new Customer();
            c.CustomerName = "Customer 1";
            c.Address = "Address";
            return c;
        }

        [NonAction]
        public string SimpleMothod() {

            return "Hi, I am not action method";
        }
        

        // GET: Test
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult GetView() {

            Employee emp = new Employee();
            emp.FirstName = "Sukesh";
            emp.LastName = "Marla";
            emp.Salary = 20000;
            ViewData["Employee"] = emp;
            return View("MyView");
        }

        public ActionResult GetView1() {
            Employee emp = new Models.Employee();
            emp.FirstName = "abraham";
            emp.LastName = "chen";
            emp.Salary = 60000;
            ViewBag.Employee = emp;
            return View("MyView1");
        }        

    }
}