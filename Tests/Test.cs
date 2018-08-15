using NUnit.Framework;
using System;
using TestFramework;

namespace Tests
{
    [TestFixture]
    public class Test
    {
        [Test]
        public void Can_Go_To_Homepage()
        {
            Pages.HomePage.GoTo();
            Assert.IsTrue(Pages.HomePage.IsAt());
        }

        [TearDown]
        public void CleanUp()
        {
            Browser.Close();
        }
    }
}
