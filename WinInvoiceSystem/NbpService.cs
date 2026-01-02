using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

public class NbpService
{
    private const string BaseUrl = "http://api.nbp.pl/api/exchangerates/rates/a/";

    public async Task<decimal> GetExchangeRateAsync(string currencyCode)
    {
        // Якщо PLN, курс завжди 1
        if (currencyCode.ToUpper() == "PLN") return 1.0m;

        using (var client = new HttpClient())
        {
            try
            {
                // Запит до NBP API
                string url = $"{BaseUrl}{currencyCode}/?format=json";
                var response = await client.GetStringAsync(url);

                var json = JObject.Parse(response);
                // Отримуємо значення курсу (mid)
                var rate = json["rates"][0]["mid"].Value<decimal>();
                return rate;
            }
            catch
            {
                return 0; // Повертаємо 0 у разі помилки
            }
        }
    }
}
