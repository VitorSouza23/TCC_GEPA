using System;
using Gepa.Resources;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Gepa.UnitTests
{
    [TestClass]
    public class PtBrTests
    {
        [TestMethod]
        public void Gepa_Test()
        {
            var expectedVlaue = "Gepa";
            var resultValue = Language.Gepa;
            Assert.AreEqual(expectedVlaue, resultValue);
        }
    }
}
