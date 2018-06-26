using System;
using System.Globalization;
using System.IO;
using System.Net;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public static decimal USD { get; set; }
        public static decimal Evro { get; set; }
        public static decimal UAN;
        static void Main(string[] args)
        {
            Listen().GetAwaiter();
            Console.WriteLine("USD  " + USD.ToString());
            Console.WriteLine("Evro  " + Evro.ToString());
            Console.Read();
        }
        private static async Task Listen()
        {
            WebRequest request = WebRequest.Create("https://api.privatbank.ua/p24api/pubinfo?exchange&coursid=5");
            using (var response = request.GetResponse())
            {
                using (var stream = response.GetResponseStream())
                {
                    using (var reader = new StreamReader(stream))
                    {
                        string data = reader.ReadToEnd();
                        if (data.Contains("USD") && data.Contains("EUR"))
                        {
                            string usd = data.Substring(data.IndexOf("USD") + "USD".Length + 22, 8);
                            string evro = data.Substring(data.IndexOf("EUR") + "EUR".Length + 22, 8);

                            try
                            {
                                USD = decimal.Parse(usd, CultureInfo.InvariantCulture);
                                Evro = decimal.Parse(evro, CultureInfo.InvariantCulture); ;


                                Console.WriteLine("Ok");

                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("Sory!");
                            }
                           

                            
                            //Console.WriteLine(data.Substring(data.IndexOf("USD") + "USD".Length + 22, 8));
                            //Console.WriteLine(data.Substring(data.IndexOf("EUR") + "EUR".Length + 22, 8));
                        }
                    }
                }
            }
        }
    }
}
