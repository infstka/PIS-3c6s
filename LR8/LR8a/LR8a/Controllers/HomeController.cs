using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LR8a.Models;
using DLLEntity;

namespace LR8a.Controllers
{
    public class HomeController : Controller
    {
        IPhoneDictionary phoneDictionary;
        public HomeController(IPhoneDictionary dictionary)
        {
            this.phoneDictionary = dictionary;
        }
        public IActionResult Index()
        {
            IEnumerable<Phone> phones = phoneDictionary.GetAll();
            ViewBag.Objects = phones;
            return View();
        }

        public IActionResult Add()
        {
            return View();
        }

        public IActionResult Update(int id)
        {
            ViewBag.Object = phoneDictionary.Find(id);
            return View();
        }
        [HttpPost]
        public IActionResult AddSave(Phone phone)
        {
            phoneDictionary.Add(phone);
            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult UpdateSave(Phone phone)
        {
            phoneDictionary.Update(phone);
            return RedirectToAction("Index");

        }
        [HttpGet]
        public ActionResult Delete(int id)
        {
            ViewBag.Object = phoneDictionary.Find(id);
            return View();
        }

        // POST: Dict/Delete/5
        [HttpPost]
        public ActionResult DeleteSave(Phone phone)
        {
            phoneDictionary.Delete(phone.Id);
            return RedirectToAction("Index");
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
