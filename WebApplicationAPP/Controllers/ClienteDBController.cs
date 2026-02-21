using Microsoft.AspNetCore.Mvc;
using WebApplicationAPP.Busines;
using WebApplicationAPP.Models;

namespace WebApplicationAPP.Controllers
{
    public class ClienteDBController : Controller
    {
        private readonly ClienteBusiness _clienteBusiness;

        public ClienteDBController(ClienteBusiness clienteBusiness)
        {
            _clienteBusiness = clienteBusiness;
        }

        public IActionResult Index()
        {
            return View(_clienteBusiness.GetAll());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Cliente cliente)
        {
            if (!ModelState.IsValid)
                return View(cliente);

            _clienteBusiness.Add(cliente);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Edit(int id)
        {
            var cliente = _clienteBusiness.GetById(id);
            if (cliente == null)
                return NotFound();

            return View(cliente);
        }

        [HttpPost]
        public IActionResult Edit(Cliente cliente)
        {
            if (!ModelState.IsValid)
                return View(cliente);

            _clienteBusiness.Update(cliente);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(int id)
        {
            var cliente = _clienteBusiness.GetById(id);
            if (cliente == null)
                return NotFound();

            return View(cliente);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmado(int id)
        {
            _clienteBusiness.Delete(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
