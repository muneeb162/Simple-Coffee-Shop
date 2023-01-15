using Microsoft.VisualStudio.TestTools.UnitTesting;
using CoffeeShop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lab10hometask;

namespace CoffeeShop.Tests
{
    [TestClass()]
    public class CoffeeTests
    {
        [TestMethod()]
        public void AmountavailableTest()
        {
            DLL obj1 = new DLL();
            string expectedresult = "Order Placed";
            string res = obj1.Amountavailable(250, 5000);
            Assert.AreEqual(expectedresult,res);
        }
    }
}