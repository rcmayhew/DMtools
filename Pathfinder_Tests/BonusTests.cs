using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pathfinder;

namespace Pathfinder_Tests
{
    [TestClass]
    public class BonusTests
    {
        public int level = 1;
        public Levels lev = Levels.trained;
        public int attribute = 13;
        public int circumstantial = 3;
        public int item = 5;
        public int status = 7;
        public int untyped = 11;

        public int forced = 4;
        
        [TestMethod]
        public void FinalBonusTestDefault()
        {
            Bonus test = new Bonus(lev, level, attribute);
            int expected = 1 + 2 + 13;
            int actaul = test.FinalBonus();
            Assert.AreEqual(expected, actaul, 0.001, 
                "Bonus with no optional arg calculating wrong. \n Expected: " + expected + " Got: " + actaul);
        }

        [TestMethod]
        public void FinalBonusTestInput()
        {
            Bonus test = new Bonus(lev, level, attribute, circumstantial, item, status, untyped);
            int expected = 1 + 2 + 13 + 3 + 5 + 7 + 11;
            int actaul = test.FinalBonus();
            Assert.AreEqual(expected, actaul, 0.001, 
                "Bonus with all optional args calculating wrong. \n Expected: " + expected + " Got: " + actaul);
        }

        [TestMethod]
        public void FinalBonusTestForced()
        {
            Bonus test = new Bonus(lev, level, attribute, circumstantial, item, status, untyped);
            test.Force(forced);
            int expected = forced;
            int actaul = test.FinalBonus();
            Assert.AreEqual(expected, actaul, 0.001, 
                "Bonus with forced value calculating wrong. \n Expected: " + expected + " Got: " + actaul);
        }


        [TestMethod]
        public void FinalBonusTestBase()
        {
            Bonus test = new Bonus();
            int expected = 1;
            int actaul = test.FinalBonus();
            Assert.AreEqual(expected, actaul, 0.001, 
                "Bonus with defualt args calculating wrong. \n Expected: " + expected + " Got: " + actaul);
        }
    }
}
