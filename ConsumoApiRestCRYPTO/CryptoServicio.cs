using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.JavaScript;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace ConsumoApiRestCRYPTO
{
    public class CryptoServicio
    {
        private readonly HttpClient _http = new HttpClient();

        //Método para consultar del exchange Kraken
        public async Task ObtenerPrecioKraken(string par)
        {

            try
            {
                var url = $"https://api.kraken.com/0/public/Ticker?pair={par}";
                var respuesta = await _http.GetStringAsync(url);

                var json = JObject.Parse(respuesta);
                var result = json["result"];
                var datos = result.First.First;
                var precio = datos["c"][0].ToString();
                
                Console.WriteLine("CRIPTOMONEDA: ETHUSDC | ETH "+precio);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.ToString());
                Console.WriteLine($"{par,-8} ERROR: {ex.Message}");
            }



        }


    }
}
