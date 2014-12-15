using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CompanyWebsite1.Controllers
{
    public class ContactController : Controller
    {
        [HttpGet]
        // GET: Contact
        public ActionResult Index()
        {
            Models.CompanyContactPage contactForm = new Models.CompanyContactPage();
            return View(contactForm);
        }
        [HttpPost]
        public ActionResult Index(Models.CompanyContactPage contactForm)
        {
            //create a gateway to the database
            Models.sp5ChaseEntities db = new Models.sp5ChaseEntities();
            //set the date created
            
            db.CompanyContactPages.Add(contactForm);
            //save changes
            db.SaveChanges();
            return View("ThankYou");
        }
    }
}