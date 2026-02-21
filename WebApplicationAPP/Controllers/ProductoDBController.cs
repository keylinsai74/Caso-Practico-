using Microsoft.AspNetCore.Mvc;
using WebApplicationAPP.Busines;
using WebApplicationAPP.Models;

namespace WebApplicationAPP.Controllers
{
    public class ProductoDBController : Controller
    {
        private readonly ProductoBusiness _productoBusiness;

        public ProductoDBController(ProductoBusiness productoBusiness)
        {
            _productoBusiness = productoBusiness;
        }

        public IActionResult Index()
        {
            return View(_productoBusiness.GetAll());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Producto producto)
        {
            if (!ModelState.IsValid)
                return View(producto);

            _productoBusiness.Add(producto);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Edit(int id)
        {
            var producto = _productoBusiness.GetById(id);
            if (producto == null)
                return NotFound();

            return View(producto);
        }

        [HttpPost]
        public IActionResult Edit(Producto producto)
        {
            if (!ModelState.IsValid)
                return View(producto);

            _productoBusiness.Update(producto);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Details(int id)
        {
            var producto = _productoBusiness.GetById(id);
            if (producto == null)
                return NotFound();

            return View(producto);
        }

        public IActionResult Delete(int id)
        {
            var producto = _productoBusiness.GetById(id);
            if (producto == null)
                return NotFound();

            return View(producto);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmar(int id)
        {
            _productoBusiness.Delete(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
