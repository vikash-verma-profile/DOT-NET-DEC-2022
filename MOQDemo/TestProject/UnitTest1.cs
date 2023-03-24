using Moq;
using OrderProcess.classes;
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
            Assert.AreEqual("Vikash 1",author.Object.FirstName);
            Assert.AreEqual("Verma 23", author.Object.LastName);
        }
        [Test]
        public void Test2()
        {
            var aritcle = new Mock<Aritcle>();
            aritcle.Setup(x => x.GetPublicationDate(It.IsAny<int>())).Returns((int x) => DateTime.Now);
            aritcle.Verify(t => t.GetPublicationDate(It.IsAny<int>()));
        }
        [Test]
        public void Test3()
        {
            var aritcle = new Mock<AuthRepositorty>() { CallBase=true};
            aritcle.Setup(x => x.IsServiceConnectionValid()).Returns(true);
           
        }
    }
}