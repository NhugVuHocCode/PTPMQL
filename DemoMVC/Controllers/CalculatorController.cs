using Microsoft.AspNetCore.Mvc;
using DemoMVC.Models;

namespace DemoMVC.Controllers
{
    public class CalculatorController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Calculator calc)
        {
            switch (calc.Operation)
            {
                case "Add":
                    calc.Result = calc.Number1 + calc.Number2;
                    break;
                case "Subtract":
                    calc.Result = calc.Number1 - calc.Number2;
                    break;
                case "Multiply":
                    calc.Result = calc.Number1 * calc.Number2;
                    break;
                case "Divide":
                    if (calc.Number2 != 0)
                        calc.Result = calc.Number1 / calc.Number2;
                    else
                        ViewBag.Error = "Không thể chia cho 0!";
                    break;
                default:
                    ViewBag.Error = "Vui lòng chọn phép toán.";
                    break;
            }

            return View(calc);
        }
    }
}
