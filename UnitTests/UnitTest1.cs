using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Domain;

namespace UnitTests
{
    [TestClass]
    public class TestAccount
    {
        [TestMethod]
        public void TestRead()
        {
            Account account = new Account();
            Assert.IsNotNull(account);
        }
    }
}
