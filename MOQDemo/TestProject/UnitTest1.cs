using Moq;
using OrderProcess.Inteface;

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
            var author = new Mock<IAuthor>();
            author.SetupGet(p=>p.Id).Returns(1);
            author.SetupGet(p => p.FirstName).Returns("Vikash");
            author.SetupGet(p => p.LastName).Returns("Verma");
            Assert.AreEqual("Vikash",author.Object.FirstName);
            Assert.AreEqual("Verma", author.Object.LastName);
        }
    }
}