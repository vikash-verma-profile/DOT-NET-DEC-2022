namespace Account
{
    internal class Program
    {
        static void Main(string[] args)
        {
           IAccount account= new Account();
            Console.WriteLine("Money deposited :{0}",account.Deposit(1000));
            Console.WriteLine("Money Withdraw :{0}", account.Withdraw(600));
            Console.WriteLine("Current Balance :{0}", account.CurrentBalance);
        }
    }
}