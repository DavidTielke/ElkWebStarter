using System.Reflection.Metadata.Ecma335;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebStarter.Data;
using WebStarter.Models;

namespace WebStarter.Controllers
{
    [Authorize(Roles = "Admin")]
    public class HomeController : Controller
    {
        private readonly DataContext _database;

        public HomeController(DataContext database)
        {
            _database = database;
        }

        public IActionResult Index()
        {
            var model = _database.Set<Person>().ToList();


            return View(model);
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Add(Person person)
        {
            _database.Set<Person>().Add(person);
            _database.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            var entity = _database.Set<Person>().Find(id);
            
            return View(entity);
        }

        [HttpPost]
        public IActionResult Edit(Person person)
        {
            _database.Set<Person>().Update(person);
            _database.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var entity = _database.Set<Person>().Find(id);
            return View(entity);
        }

        public IActionResult DeleteConfirmed(int id)
        {
            var entity = _database.Set<Person>().Find(id);
            if (entity != null)
            {
                _database.Set<Person>().Remove(entity);
                _database.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}
