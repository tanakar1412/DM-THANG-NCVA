using asdasda.Models;
using Microsoft.AspNetCore.Mvc;

namespace asdasda.Controllers
{
    public class KmsController : Controller
    {
        private readonly PhucDbContext _db;

        public KmsController(PhucDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var sinhvien = _db.sinhViens.ToList();
            return View(sinhvien);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(SinhVien sv)
        {
            _db.sinhViens.Add(sv);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Details(Guid id)
        {
            var sv = _db.sinhViens.FirstOrDefault(x => x.id == id);
            return View(sv);
        }

        public IActionResult Edit(Guid id)
        {
            var sv = _db.sinhViens.FirstOrDefault(x => x.id == id);
            return View(sv);
        }

        [HttpPost]

        public IActionResult Edit(SinhVien sv)
        {
            _db.sinhViens.Update(sv);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }


        public IActionResult Delete(Guid id)
        {
            var sv = _db.sinhViens.FirstOrDefault(x => x.id == id);
            return View(sv);
        }

        [HttpPost ,ActionName("Delete")]
        public IActionResult kms(Guid id)
        {
            var sv = _db.sinhViens.FirstOrDefault(x => x.id == id);
            _db.sinhViens.Remove(sv);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
