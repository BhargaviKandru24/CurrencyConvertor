using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using currency = CurrencyConvertor;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var value = currency.Currency.Convertor(123, "usd", "inr");
        }
    }
}
