using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;

namespace CurrencyExchageWebpage
{
    public class ExchangeRateProcessor
    {
        public static async Task<ExchangeRateModel> LoadSource()
        {
            string url = "http://www.apilayer.net/api/live?access_key=244c0ecd519fa825e38dcafb80059220&format=1";

            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    ExchangeRateModel source = await response.Content.ReadAsAsync<ExchangeRateModel>();

                    return source;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }

    }
}