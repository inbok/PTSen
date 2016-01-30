using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProtocolAnalysisUsingSentinel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtocolAnalysisUsingSentinel.Tests
{
    [TestClass()]
    public class Form1Tests
    {
        [TestMethod()]
        public void testCodeTest()
        {
            Form1 testForm = new Form1();
            Assert.AreEqual(true, testForm.testCode());
        }
    }
}