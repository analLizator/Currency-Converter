using Microsoft.AspNetCore.Mvc;

namespace ASP_proekt_1_currency_converter.Models
{
    public class CurrencyRates
    {
        public static Dictionary<string, decimal> Rates = new()
        {
            { "BGN", 1.95583m },
            { "EUR", 1.0m },
            { "USD", 1.1631m }, // реално на едно място пише, че е 1.08
            { "GBP", 0.8671m }, // британска лира
            { "JPY", 183.69m }, // японски йен
            { "CHF", 0.9282m }, // швейцарски франк
            { "CZK", 24.29m }, // чешка крона
            { "DKK", 7.4717m }, // датска крона
            { "TRY", 50.28m }, // турска лира
            { "INR", 89.0m }, // индийска рупия
        };
    }
}
