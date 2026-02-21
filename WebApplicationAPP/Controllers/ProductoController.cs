using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using WebApplicationAPP.Models;

namespace WebApplicationAPP.Controllers
{
    public class ProductoController : Controller
    {
        //declaraciones de variables
        private static List<Producto> productos = new();

        private static int contadorIds = 1;

        private static bool isInitialized = false;

        public ProductoController()
        {

            if (!isInitialized)
            {
                productos.AddRange(new List<Producto>
                {
                    new Producto { Id = contadorIds++, Nombre = "Producto A", Precio = 10.99m, Stock = 100 },
                    new Producto { Id = contadorIds++, Nombre = "Producto B", Precio = 15.49m, Stock = 50 },
                    new Producto { Id = contadorIds++, Nombre = "Producto C", Precio = 7.25m, Stock = 200 }
                });

                isInitialized = true;
            }

        }



        public IActionResult Index()
        {
            return View(productos);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Models.Producto producto)
        {
            if (!ModelState.IsValid)
            {
                // Aquí se podría agregar la lógica para guardar el producto en una base de datos
                //return RedirectToAction("Index");
                return View(producto);
            }

            productos.Add(new Producto
            {
                Id = contadorIds++,
                Nombre = producto.Nombre,
                Precio = producto.Precio,
                Stock = producto.Stock
            });

            return RedirectToAction(nameof(Index));

        }

        //Details
        public IActionResult Details(int id)
        {
            var datosConsulta = productos.FirstOrDefault(p => p.Id == id);

            if (datosConsulta == null)
            {
                return NotFound();
            }

            return View(datosConsulta);
        }


        public IActionResult Edit(int id)
        {
            var datosConsulta = productos.FirstOrDefault(p => p.Id == id);

            if (datosConsulta == null)
            {
                return NotFound();
            }

            return View(datosConsulta);
        }

        [HttpPost]
        public IActionResult Edit(Producto producto)
        {
            var datosConsulta = productos.FirstOrDefault(p => p.Id == producto.Id);

            if (datosConsulta == null)
            {
                return NotFound();
            }


            if (!ModelState.IsValid)
            {
                // Aquí se podría agregar la lógica para guardar el producto en una base de datos
                //return RedirectToAction("Index");
                return View(producto);
            }

            datosConsulta.Nombre = producto.Nombre;
            datosConsulta.Precio = producto.Precio;
            datosConsulta.Stock = producto.Stock;

            return RedirectToAction(nameof(Index));
        }



        public IActionResult Delete(int id)
        {
            var datosConsulta = productos.FirstOrDefault(p => p.Id == id);

            if (datosConsulta == null)
            {
                return NotFound();
            }

            return View(datosConsulta);
        }



        [HttpPost]
        public IActionResult Delete(Producto producto)
        {
            var datosConsulta = productos.FirstOrDefault(p => p.Id == producto.Id);

            if (datosConsulta == null)
            {
                return NotFound();
            }

            productos.Remove(datosConsulta);

            return RedirectToAction(nameof(Index));
        }
    }
}


