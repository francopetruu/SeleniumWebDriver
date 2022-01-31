using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1.TestScript.TestContextClass
{
    [TestClass]
    public class TestContextClass
    {
        private TestContext testContext;

        //Property to fetch and assign value to testContext variable 
        public TestContext TestContext
        {
            get { return testContext; }
            set { testContext = value; }
        }

        [TestMethod]
        public void TestCase1()
        {
            Console.WriteLine("Test name: " + testContext.TestName);
        }

        [TestMethod]
        public void TestCase2()
        {
            Console.WriteLine("Test name: " + testContext.TestName);
        }

        [TestCleanup]
        public void AfterTest()
        {
            Console.WriteLine("Result: " + testContext.CurrentTestOutcome);
        }
    }
}
