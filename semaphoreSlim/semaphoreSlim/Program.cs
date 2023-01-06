using Newtonsoft.Json;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace semaphoreSlim
{
    internal class Program
    {
        static SemaphoreSlim semaphoreSlim = new SemaphoreSlim(3);
        static void Main(string[] args)
        {
            //allowing maximum 3 tasks to be executed at a time

            Console.WriteLine("Main Thread Started");
            List<CreditCard> creditCards = CreditCard.GenerateCreditCards(15);
            ProccessCreditCards(creditCards);
            Console.WriteLine("Main Thread Ended");
        }

        static async Task<string> ProcessCard(CreditCard creditCard)
        {
            await Task.Delay(1000);
            //string result = $"Credit card Number : {creditCard.CardNumber} Name: {creditCard.Name} Processed";
            //
            //Console.WriteLine($"Credit card number processed : {creditCard.CardNumber} ");

            var creditCardResponse = new CreditCardResponses
            {
                CardNumber = Convert.ToInt64(creditCard.CardNumber),
                Name = creditCard.Name,
                IsProcessed = (Convert.ToInt64(creditCard.CardNumber) % 2 == 0) ? true : false
            };
            string result = JsonConvert.SerializeObject(creditCardResponse);
            return result;
        }

        static async void ProccessCreditCards(List<CreditCard> creditCards)
        {
            var ObjStopwatch = new Stopwatch();
            ObjStopwatch.Start();
            //creating tasks List
            var tasks = new List<Task<string>>();
            tasks = creditCards.Select(async card =>
            {
                await semaphoreSlim.WaitAsync();
                try
                {
                    return await ProcessCard(card);
                }
                finally
                {
                    semaphoreSlim.Release();
                }
            }).ToList();
            //response a string array
            var responses = await Task.WhenAll(tasks);

            List<CreditCardResponses> creditCardResponses = new List<CreditCardResponses>();
            foreach (var response in responses)
            {
                CreditCardResponses creditCardResponse = JsonConvert.DeserializeObject<CreditCardResponses>(response);
                creditCardResponses.Add(creditCardResponse);
            }
            Console.WriteLine("Approved Credit Cards");
            foreach (var item in creditCardResponses.Where(card => card.IsProcessed == true))
            {
                Console.WriteLine($"Card Number {item.CardNumber}");
            }
            Console.WriteLine("Rejected Credit Cards");
            foreach (var item in creditCardResponses.Where(card => card.IsProcessed == false))
            {
                Console.WriteLine($"Card Number {item.CardNumber}");
            }

            ObjStopwatch.Stop();
            Console.WriteLine($"Processing of {creditCards.Count} Credit Cards Done in {ObjStopwatch.ElapsedMilliseconds / 1000} Seconds");

        }
        public class CreditCard
        {
            public string CardNumber { get; set; }
            public string Name { get; set; }

            public static List<CreditCard> GenerateCreditCards(int number)
            {
                List<CreditCard> creditCards = new List<CreditCard>();
                for (int i = 0; i < number; i++)
                {
                    CreditCard card = new CreditCard()
                    {
                        CardNumber = "10000000" + i,
                        Name = "CreditCard-" + i
                    };
                    creditCards.Add(card);
                }
                return creditCards;
            }
        }

        public class CreditCardResponses
        {
            public long CardNumber { get; set; }
            public string Name { get; set; }
            public bool IsProcessed { get; set; }
        }
    }
}