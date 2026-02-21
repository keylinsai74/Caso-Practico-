using Microsoft.AspNetCore.Mvc;
using WebApplicationAPP.Models;

namespace WebApplicationAPP.Controllers
{
    public class CalculadoraController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View(new CalculadoraViewModel());
        }

        [HttpPost]
        public IActionResult Index(CalculadoraViewModel modelo)
        {
           
            if (modelo.operacion == "suma")
            {
                modelo.resultado = modelo.valor1 + modelo.valor2;
            }
            else if (modelo.operacion == "resta")
            {
                modelo.resultado = modelo.valor1 - modelo.valor2;
            }
            else if (modelo.operacion == "multiplicacion")
            {
                modelo.resultado = modelo.valor1 * modelo.valor2;
            }
            else if (modelo.operacion == "division")
            {
             
                if (modelo.valor2 != 0)
                {
                    modelo.resultado = modelo.valor1 / modelo.valor2;
                }
            }

            return View(modelo);
        }
    }
}