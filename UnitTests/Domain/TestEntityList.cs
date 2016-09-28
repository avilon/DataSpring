using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Domain;

namespace UnitTests.Domain
{
    [TestClass]
    public class TestEntityList
    {
        [TestMethod]
        public void TestLoad()
        {
            EntityList<Account> list = new EntityList<Account>();
            Assert.IsNotNull(list);
            list.Load(@"E:\Data\acct\acct_0000000001.csv");
            Assert.AreEqual(99996, list.Count);
        }
    }
}
