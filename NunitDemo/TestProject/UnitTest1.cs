using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using SampleApi.Controllers;

namespace TestProject
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            HomeController home = new HomeController();
            string result = home.GetEmployeeName(1);
            Assert.AreEqual("Vikash", result);
        }
        [Test]
        public void Test2()
        {
            HomeController home = new HomeController();
            string result = home.GetEmployeeName(2);
            Assert.AreEqual("Vikas", result);
        }
        [TestCase(1, "Vikash")]
        [TestCase(2, "Kumar")]
        [TestCase(3, "Not Found")]
        public void Test2(int empId, string name)
        {
            HomeController home = new HomeController();
            string result = home.GetEmployeeName(empId);
            Assert.AreEqual(name, result);
        }
        [Test]
        public void Test4()
        {
            var serviceProvider = new ServiceCollection().AddLogging().BuildServiceProvider();
            var factory = serviceProvider.GetService<ILoggerFactory>();
            var logger= factory.CreateLogger<TestingController>();
            TestingController home = new TestingController(logger);
            string result = home.GetMessage();
            Assert.AreEqual("Hi !", result);
        }
    }
}