using Microsoft.AspNetCore.Mvc;

namespace ASP_proekt_1_currency_converter.Models
{
    public class CurrencyConverterModel
    {
        public decimal Amount { get; set; }
        public string FromCurrency { get; set; }
        public string ToCurrency { get; set; }
        public decimal Result { get; set; }
        public int Decimals { get; set; } = 2;
        public bool HasResult { get; set; }
    }
}
