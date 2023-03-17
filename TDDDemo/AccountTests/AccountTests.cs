using Account;
namespace AccountTests
{
    [TestClass]
    public class AccountTests
    {
        [TestMethod]
        public void CurrentBalanceTestPostiveCase()
        {
            IAccount account = new Account.Account();
            account.Deposit(100);
            double result = account.CurrentBalance;
            Assert.AreEqual(100, result);
        }
        [TestMethod]
        public void DepositTestPostiveCase()
        {
            IAccount account = new Account.Account();
            double result=account.Deposit(100);
            Assert.AreEqual(100, result);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void DepositTestNegativeAmount()
        {
            IAccount account = new Account.Account();
            double result = account.Deposit(-100);
        }
        [TestMethod]
        public void WithdrawTestPostiveCase()
        {
            IAccount account = new Account.Account();
            account.Deposit(500);
            double result = account.Withdraw(400);
            Assert.AreEqual(100, result);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void WithdrawTestNegativeWithdrawAmount()
        {
            IAccount account = new Account.Account();
            account.Deposit(200);
            double result = account.Withdraw(-300);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void WithdrawTestWithMoreWithdrawAmountThanDeposit()
        {
            IAccount account = new Account.Account();
            account.Deposit(200);
            double result = account.Withdraw(300);
        }
    }
}