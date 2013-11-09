using Monopoly;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MonopolyTestProject
{
    
    
    /// <summary>
    ///This is a test class for DobbelsteenTest and is intended
    ///to contain all DobbelsteenTest Unit Tests
    ///</summary>
    [TestClass()]
    public class DobbelsteenTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for Gooi
        ///</summary>
        [TestMethod()]
        public void GooiTest()
        {
            Dobbelsteen_Accessor target = new Dobbelsteen_Accessor();
            const int totaalAantalGooien = 10000;

            int totaal = 0;
            for (int i = 0; i < totaalAantalGooien; i++)
            {
                int gegooid = target.Gooi();
                totaal += gegooid;
                Assert.IsTrue(gegooid >= 1, "Dobbelsteen gooide minder dan 1");
                Assert.IsTrue(gegooid <= 6, "Dobbelsteen gooide meer dan 6");
            }
            Assert.IsTrue(
                totaal != totaalAantalGooien * 1 &&
                totaal != totaalAantalGooien * 2 &&
                totaal != totaalAantalGooien * 3 &&
                totaal != totaalAantalGooien * 4 &&
                totaal != totaalAantalGooien * 5 &&
                totaal != totaalAantalGooien * 6,
                "De dobbelsteen gooit altijd hetzelfde");
        }

    }
}
