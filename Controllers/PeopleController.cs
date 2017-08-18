using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCDemo.Models;

namespace MVCDemo.Controllers
{
    public class PeopleController : Controller
    {
        // GET: People
        public ActionResult Index()
        {
            PersonModel p = new PersonModel();
            int i = 5 / p.Age;
            return View();
        }

        public ActionResult ListPeople()
        {
            List<PersonModel> people = new List<PersonModel>();
            people.Add(new PersonModel { FirstName = "Gemini", LastName = "Jain", Age = 26 });
            people.Add(new PersonModel { FirstName = "Tanmay", LastName = "Baid", Age = 28 });
            people.Add(new PersonModel { FirstName = "Somebody", LastName = "Everybody", Age = 50 });
            return View(people);
        }

    }
}