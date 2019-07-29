using System;
using Newtonsoft.Json;
using System.Net;
using System.IO;
using System.Collections.Generic;

namespace TronaldDrumpApi
{
    class Program
    {
        static void Main(string[] args)
        {
            var url = string.Empty;
            Console.WriteLine("Would You LIke a Random Quote?:");
            var random = Console.ReadLine();
            if(random.ToUpper() == "YES")
            {
                url = "https://api.tronalddump.io/random/quote";
                var request = WebRequest.Create(url);
                var response = request.GetResponse();
                var rawResponse = string.Empty;

                using (var reader = new StreamReader(response.GetResponseStream()))
                {
                    rawResponse = reader.ReadToEnd();
                }

                var trumpQuote = JsonConvert.DeserializeObject<Quote>(rawResponse);
                Console.WriteLine(trumpQuote.value);
            }
            else
            {
                Console.WriteLine("Who would you like a quote about?:");
                var query = Console.ReadLine();
                url = $"https://api.tronalddump.io/search/quote?query={query}";

                var request = WebRequest.Create(url);
                var response = request.GetResponse();
                var rawResponse = string.Empty;

                using (var reader = new StreamReader(response.GetResponseStream()))
                {
                    rawResponse = reader.ReadToEnd();
                }

                var trumpQuote = JsonConvert.DeserializeObject<RootObject>(rawResponse);
                var quoteList = trumpQuote._embedded.quotes;

                foreach(var quote in quoteList)
                {
                        Console.WriteLine(quote.value);
                }
            }
        }
    }
}
