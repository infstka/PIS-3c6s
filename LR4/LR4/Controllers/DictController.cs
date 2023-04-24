// Определение пространства имен, используемых классом
using LR4.Models;
using System;
using System.Linq;
using System.Web.Mvc;
using System.Data.Entity;

// Объявление пространства имен проекта и контроллера Dict
namespace LR4.Controllers
{
    public class DictController : Controller
    {
        // Создание объекта контекста БД
        PhoneBookContext DB = new PhoneBookContext();

        // Определение метода для обработки GET запроса на страницу по умолчанию
        public ActionResult Index()
        {
            // Получение списка контактов из БД и упорядочивание их по фамилии перед передачей в ViewBag
            ViewBag.PhoneBooks = DB.Contacts.OrderBy(entry => entry.LastName);
            return View();
        }

        // Определение метода для обработки GET запроса на страницу добавления нового контакта
        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }

        // Определение метода для обработки POST запроса на сохранение нового контакта
        [HttpPost]
        public RedirectResult AddSave(string lastName, string phone)
        {
            // Добавление нового контакта в БД и сохранение изменений
            DB.Contacts.Add(new Contact() { LastName = lastName, Number = phone });
            DB.SaveChanges();

            // Обновление ViewBag с новым списком контактов и перенаправление на страницу по умолчанию
            ViewBag.PhoneBooks = DB.Contacts;
            return Redirect("/Dict/Index");
        }

        // Определение метода для обработки GET запроса на страницу редактирования контакта
        [HttpGet]
        public ActionResult Update(string id)
        {
            // Получение id контакта, передача его в ViewBag и получение списка контактов для передачи в ViewBag
            ViewBag.Id = id;
            ViewBag.PhoneBooks = DB.Contacts;
            return View();
        }

        // Определение метода для обработки POST запроса на сохранение изменений контакта
        [HttpPost]
        public RedirectResult UpdateSave(string id, string lastName, string phone)
        {
            // Нахождение контакта по id, изменение его фамилии и номера телефона, сохранение изменений и обновление ViewBag с новым списком контактов
            Contact contact = DB.Contacts.Find(Int32.Parse(id));
            if (contact != null)
            {
                contact.LastName = lastName;
                contact.Number = phone;

                DB.Entry(contact).State = EntityState.Modified;
                DB.SaveChanges();

                ViewBag.PhoneBooks = DB.Contacts;
            }

            // Перенаправление на страницу по умолчанию
            ViewBag.PhoneBooks = DB.Contacts;
            return Redirect("/Dict/Index");
        }

        // Определение метода для обработки GET запроса на страницу удаления контакта
        [HttpGet]
        public ActionResult Delete(string id)
        {
            // Получение id контакта для передачи в ViewBag
            ViewBag.Id = id;
            return View();
        }

        // Определение метода для обработки POST запроса на удаление контакта
        [HttpPost]
        public ActionResult DeleteSave(string id)
        {
            // Нахождение контакта по id, удаление его из БД, сохран
            Contact contact = DB.Contacts.Find(Int32.Parse(id)); // Находим контакт по идентификатору и преобразуем строку в число
            if (contact != null) // Если контакт найден
            {
                DB.Contacts.Remove(contact); // Удаляем контакт из базы данных
                DB.SaveChanges(); // Сохраняем изменения в базе данных

                ViewBag.PhoneBooks = DB.Contacts; // Обновляем список контактов в ViewBag
            }

            return View("Index"); // Возвращаем представление Index, чтобы показать обновленный список контактов
        }
    }
}