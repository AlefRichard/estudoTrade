using Entidades;
using Newtonsoft.Json;
using System.Net;

namespace estudoTrade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Buscar dados
           List<Candle> dados = GetDados("ETH_USDT", "DAY_1");

            //Calculadora
            int quantidade = dados.Count();

            //Ação
             //Comprar
            Console.WriteLine(dados);

        }

        public static List<Candle> GetDados(string market, string interval)
        {
            WebRequest request = WebRequest.Create(string.Format(@"https://api.poloniex.com/markets/{0}/candles?interval={1}", market, interval));
            WebResponse response = request.GetResponse();
            Stream datastream = response.GetResponseStream();
            StreamReader reader = new StreamReader(datastream);              
            var content = reader.ReadToEnd();

            List<Candle> data = JsonConvert.DeserializeObject<List<Candle>>(content);

            if (data == null)
                throw new Exception();
            else
                return data;



        }

    }
}