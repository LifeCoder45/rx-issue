using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RxTest.Lib;

namespace RxTest.Unit
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var x = new Class1().TestObservable;
        }
    }
}
