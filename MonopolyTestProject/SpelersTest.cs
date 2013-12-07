using Monopoly;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MonopolyTestProject
{
    
    
    /// <summary>
    ///This is a test class for SpelersTest and is intended
    ///to contain all SpelersTest Unit Tests
    ///</summary>
    [TestClass()]
    public class SpelersTest
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
        ///A test for Shuffle
        ///</summary>
        [TestMethod()]
        public void ShuffleTest()
        {
            Spelers spelers = new Spelers();

            Speler klaasje = new Speler("Klaasje", 25, System.Drawing.Color.Yellow);
            Speler henkie = new Speler("Henkie", 33, System.Drawing.Color.Red);
            Speler pol = new Speler("Pol", 26, System.Drawing.Color.Blue);
            Speler wiesje = new Speler("Wiesje", 29, System.Drawing.Color.Green);

            spelers.Add(klaasje);
            spelers.Add(henkie);
            spelers.Add(pol);
            spelers.Add(wiesje);

            Spelers geschuddeSpelers = new Spelers();

            geschuddeSpelers.Add(klaasje);
            geschuddeSpelers.Add(henkie);
            geschuddeSpelers.Add(pol);
            geschuddeSpelers.Add(wiesje);

            geschuddeSpelers.Shuffle();

            bool hebbenDezelfdeVolgorde = true;
            for (int i = 0; i < 4; i++)
            {
                Speler speler = spelers.HuidigeSpeler;
                Speler geschuddeSpeler = geschuddeSpelers.HuidigeSpeler;

                if (speler.Naam != geschuddeSpeler.Naam)
                {
                    hebbenDezelfdeVolgorde = false;
                    break;
                }
                spelers.Volgende();
                geschuddeSpelers.Volgende();
            }

            Assert.IsFalse(hebbenDezelfdeVolgorde, "De spelers zijn niet goed geschud");
        }
    }
}
