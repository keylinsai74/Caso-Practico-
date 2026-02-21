using Microsoft.AspNetCore.Mvc;
using WebApplicationAPP.Business;
using WebApplicationAPP.Models;

namespace WebApplicationAPP.Controllers
{
    public class InventarioController : Controller
    {
        private readonly InventarioBusiness _inventarioBusiness;

        public InventarioController(InventarioBusiness inventarioBusiness)
        {
            _inventarioBusiness = inventarioBusiness;
        }

        public IActionResult Index()
        {
            var lista = _inventarioBusiness.GetAll();
            return View(lista);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Inventario inventario)
        {
            if (ModelState.IsValid)
            {
                _inventarioBusiness.Add(inventario);
                return RedirectToAction("Index");
            }

            return View(inventario);
        }

        public IActionResult Edit(int id)
        {
            var inventario = _inventarioBusiness.GetById(id);

            if (inventario == null)
                return NotFound();

            return View(inventario);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Inventario inventario)
        {
            if (ModelState.IsValid)
            {
                _inventarioBusiness.Update(inventario);
                return RedirectToAction("Index");
            }

            return View(inventario);
        }

        public IActionResult Delete(int id)
        {
            var inventario = _inventarioBusiness.GetById(id);

            if (inventario == null)
                return NotFound();

            return View(inventario);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            _inventarioBusiness.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
