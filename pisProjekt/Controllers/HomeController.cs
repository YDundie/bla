using pisProjekt.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace pisProjekt.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext _context;

        public HomeController() {
            this._context = new ApplicationDbContext();

        }

        public ActionResult Index()
        {


            var imenk = _context.upis;

            return View(imenk);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult info(int id)
        {
            var model = _context.upis.FirstOrDefault(_ => _.id == id);

            return View(model);
        }

        public ActionResult edit(int id)
        {
            var cusotmerInDb = _context.upis.Single(c => c.id == id);

            return View(cusotmerInDb);
        }

        [HttpPost]
        public ActionResult edit(upis Customer)
        {
            var cusotmerInDb = _context.upis.Single(c => c.id == Customer.id);
            cusotmerInDb.ime = Customer.ime;
            cusotmerInDb.prezime = Customer.prezime;
            cusotmerInDb.brojAdrese = Customer.brojAdrese;
            cusotmerInDb.brojTelefona = Customer.brojTelefona;
            cusotmerInDb.adresa = Customer.adresa;
            cusotmerInDb.grad = Customer.grad;
            cusotmerInDb.zemlja = Customer.zemlja;

            _context.SaveChanges();

            return RedirectToAction("Index", "Home");
        }

        public ActionResult deleteUpis(int id)
        {
            var cusotmerInDb = _context.upis.SingleOrDefault(c => c.id == id);

            _context.upis.Remove(cusotmerInDb);
            _context.SaveChanges();
           

            return RedirectToAction("Index", "Home");
        }

        public ActionResult dodajBroj()
        {

            return View();
        }

        [HttpPost]
        public ActionResult dodajBroj(upis Customer)
        {
            _context.upis.Add(Customer);
            _context.SaveChanges();

            return RedirectToAction("Index", "Home");
        }
    }
}