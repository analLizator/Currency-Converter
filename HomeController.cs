using ASP_proekt_1_currency_converter.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ASP_proekt_1_currency_converter.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View(new CurrencyConverterModel());
        }

        [HttpPost]
        public IActionResult Index(CurrencyConverterModel model)
        {
            if (model.FromCurrency == model.ToCurrency)
            {
                ViewBag.Error = "Моля, изберете различни валути.";
                return View(model);
            }
            var fromRate = CurrencyRates.Rates[model.FromCurrency];
            var toRate = CurrencyRates.Rates[model.ToCurrency];
            if (model.FromCurrency == model.ToCurrency)
            {
                ViewBag.Error = "Моля, изберете различни валути.";
                model.HasResult = false;
                return View(model);
            }

            model.Result = Math.Round(model.Amount / fromRate * toRate, model.Decimals);
            model.HasResult = true;
            return View(model);
        }
    }
}
