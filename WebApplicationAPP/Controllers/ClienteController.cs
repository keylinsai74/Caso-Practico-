using Microsoft.AspNetCore.Mvc;
using WebApplicationAPP.Models;

namespace WebApplicationAPP.Controllers
{
    public class ClienteController : Controller
    {
        private static List<Cliente> clientes = new();
        private static int contadorIds = 1;
        private static bool isInitialized = false;

        public ClienteController()
        {
            if (!isInitialized)
            {
                clientes.Add(new Cliente { Id = contadorIds++, Nombre = "Juan Pérez", Correo = "juan@mail.com", Telefono = "8888-1111" });
                isInitialized = true;
            }
        }

        public IActionResult Index() => View(clientes); // Listar clientes

        public IActionResult Create() => View();

        [HttpPost]
        public IActionResult Create(Cliente cliente) // Registrar nuevos clientes
        {
            cliente.Id = contadorIds++;
            clientes.Add(cliente);
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id) => View(clientes.FirstOrDefault(c => c.Id == id));

        [HttpPost]
        public IActionResult Edit(Cliente cliente) // Editar información
        {
            var temp = clientes.FirstOrDefault(c => c.Id == cliente.Id);
            if (temp != null)
            {
                temp.Nombre = cliente.Nombre;
                temp.Correo = cliente.Correo;
                temp.Telefono = cliente.Telefono;
            }
            return RedirectToAction("Index");
        }

        public IActionResult Details(int id) => View(clientes.FirstOrDefault(c => c.Id == id)); // Visualizar detalles

        public IActionResult Delete(int id) => View(clientes.FirstOrDefault(c => c.Id == id)); // Confirmación previa

        [HttpPost]
        public IActionResult Delete(Cliente cliente) // Eliminar clientes
        {
            var temp = clientes.FirstOrDefault(c => c.Id == cliente.Id);
            if (temp != null) clientes.Remove(temp);
            return RedirectToAction("Index");
        }
    }
}