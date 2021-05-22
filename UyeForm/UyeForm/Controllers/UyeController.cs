using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UyeForm.Models;
namespace UyeForm.Controllers
{
    public class UyeController : Controller
    {
        // GET: Uye
        FormEntities Db = new FormEntities();
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Ekle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Ekle(UyeDb veri)
        {
            Db.UyeDb.Add(veri);
            Db.SaveChanges();
            return View();
        }
    }
}