using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xunit.Sdk;

namespace HelloWorld.Test
{
    [TestClass]
    public class HelloWorldMakerTest
    {
        [TestMethod]
        public void TestGreetingsNullFail()
        {
            HelloWorldMaker helloWorldMaker = new HelloWorldMaker();
            var result = helloWorldMaker.Greetings(null);

            Assert.IsFalse(string.IsNullOrEmpty(result));
        }

        [TestMethod]
        public void TestGreetingsHasTextFail()
        {
            HelloWorldMaker helloWorldMaker = new HelloWorldMaker();
            var result = helloWorldMaker.Greetings(string.Empty);

            Assert.IsFalse(string.IsNullOrEmpty(result));
        }

        [TestMethod]
        public void TestGreetingsHasNameSuccess()
        {
            HelloWorldMaker helloWorldMaker = new HelloWorldMaker();
            var result = helloWorldMaker.Greetings("Pascal");

            Assert.IsTrue(result.Contains("Pascal"));
        }
    }
}
