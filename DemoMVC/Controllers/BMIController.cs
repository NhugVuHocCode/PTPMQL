using Microsoft.AspNetCore.Mvc;
using DemoMVC.Models;

namespace DemoMVC.Controllers
{
    public class BMIController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(BMI model)
        {
            if (model.Height > 0)
            {
                model.Result = model.Weight / (model.Height * model.Height);

                if (model.Result < 18.5)
                    model.Category = "Gầy";
                else if (model.Result < 24.9)
                    model.Category = "Bình thường";
                else if (model.Result < 29.9)
                    model.Category = "Thừa cân";
                else
                    model.Category = "Béo phì";
            }
            else
            {
                ViewBag.Error = "Chiều cao phải > 0";
            }

            return View(model);
        }
    }
}
