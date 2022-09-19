using ASP.NET_Projekt_poznawczy.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NET_Projekt_poznawczy.Controllers
{
    public class CategoryController : Controller
    {
        private readonly AppticationDbContext _db;
        public CategoryController(AppticationDbContext db)
        {
            _db = db; // W tej metodzie wartość readonly może zostać zmieniona
        }
        public IActionResult Index()
        {
            IEnumerable<Category> objCatrgoryList = _db.Categories;
            return View(objCatrgoryList);
        }

        //GET
        //Pobiera wartości 
        public IActionResult Create()
        {
            return View();
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken] //Zapobiega fałszerstą
        public IActionResult Create(Category obj)
        {
            if (obj.Name == obj.DisplayOrder.ToString())
            {
                ModelState.AddModelError("Błąd", "Nazwa nie może być taka sama jak nazwa");
            }
            if (ModelState.IsValid)
            {
                _db.Categories.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index"); //Przekierowanie do Indexu pokazuje
            }
            return View(obj);
        }

        //GET
        //Pobiera wartości Edit
        public IActionResult Edit(int? id) //Musi być nazwa Id
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            //var categoryFromDb = _db.Categories.Find(id);
            var categoryFromDbFirst = _db.Categories.FirstOrDefault(o => o.Id == id);
            //var categoryFromDbSingle = _db.Categories.SingleOrDefault(o => o.Id == number);
            if (categoryFromDbFirst == null)
            {
                return NotFound();
            }
            return View(categoryFromDbFirst);
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken] //Zapobiega fałszerstą
        public IActionResult Edit(Category obj)
        {
            if (obj.Name == obj.DisplayOrder.ToString())
            {
                ModelState.AddModelError("Błąd", "Nazwa nie może być taka sama jak nazwa");
            }
            if (ModelState.IsValid)
            {
                _db.Categories.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index"); //Przekierowanie do Indexu pokazuje
            }
            return View(obj);
        }

        //Post
        //Pobiera wartości Delete

        public async Task<IActionResult> DeletePost(int? id) //Musi być nazwa Id
        {
            var categoryFromDbFirst = await _db.Categories.FindAsync(id);
            if (categoryFromDbFirst != null)
            {
                var DeleteCategory = _db.Categories.Remove(categoryFromDbFirst);
                await _db.SaveChangesAsync();
                return RedirectToAction("Index"); //Przekierowanie na
            }
            else
            {
                ModelState.AddModelError("", "Kategoria Not Found");
            }
            return View(categoryFromDbFirst);
        }

        public IActionResult Kalkulator()
        {
            return View();
        }


    }
}
