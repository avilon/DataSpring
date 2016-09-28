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
            account.Read("\"0037100000\";\"NTFL\";\"01.04.2007\";\"SESB\";\"0037100834\"");
            Assert.AreEqual("0037100000", account.Id);
            Assert.AreEqual("NTFL", account.BillCycle);
            Assert.AreEqual("SESB", account.CisDivision);
            Assert.AreEqual("0037100834", account.MailingPremId);
        }
    }
}
