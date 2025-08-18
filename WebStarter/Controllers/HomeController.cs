using Microsoft.AspNetCore.Mvc;
using WebStarter.Models;

namespace WebStarter.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var model = new List<Person>
            {
                new Person(1, "David", "Tielke", 41),
                new Person(2, "Lena", "Tielke", 39),
                new Person(3, "Maximilian", "Tielke", 12),
                new Person(4, "Lisa", "Tielke", 2),
            };


            return View(model);
        }

        public IActionResult Add()
        {
            return View();
        }

        public IActionResult Edit(int id)
        {
            return View();
        }
    }
}
