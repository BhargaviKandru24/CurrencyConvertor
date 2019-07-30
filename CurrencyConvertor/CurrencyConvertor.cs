using System;
using System.Net;

namespace CurrencyConvertor
{
    public static class Currency
    {
        public static string Convertor(decimal amount, string fromType, string toType)
        {
            const string urlPattern = "http://rate-exchange-1.appspot.com/currency?from={0}&to={1}";
            string url = string.Format(urlPattern, fromType, toType);

            // Get response as string
            string response = new WebClient().DownloadString(url);

            Newtonsoft.Json.Linq.JToken token = Newtonsoft.Json.Linq.JObject.Parse(response);
            decimal exchangeRate = (decimal)token.SelectToken("rate");

            // Output the result

            return (amount * exchangeRate).ToString();
        }
    }
}
