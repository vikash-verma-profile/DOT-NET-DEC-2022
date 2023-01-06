// See https://aka.ms/new-console-template for more information

using System.Diagnostics;
using System.Threading;
SemaphoreSlim semaphoreSlim = new SemaphoreSlim(3);
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
    string result = $"Credit card Number : {creditCard.CardNumber} Name: {creditCard.Name} Processed";
    Console.WriteLine($"Credit card number processed : {creditCard.CardNumber} ");
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
        await semaphoreSlim.wa
    }).ToList();
    await Task.WhenAll(tasks);

    ObjStopwatch.Stop();
    Console.WriteLine($"Processing of {creditCards.Count} Credit Cards Done in {ObjStopwatch.ElapsedMilliseconds/1000} Seconds");

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