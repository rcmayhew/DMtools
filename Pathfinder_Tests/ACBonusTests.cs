using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pathfinder;


namespace Pathfinder_Tests
{
    [TestClass]
    public class ACBonusTests
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
        public void FinalACBonusDefault()
        {
            ACBonus ac = new ACBonus(lev, level, attribute);
            int expected = 1 + 2 + 13 + 10;
            int actual = ac.FinalACBonus();
            Assert.AreEqual(expected, actual, 0.001,
                "ACBonus with defualt args calculating wrong. \n Expected: " + expected + " Got: " + actual);
        }

        [TestMethod]
        public void FinalACBonusInput()
        {
            ACBonus ac = new ACBonus(lev, level, attribute, circumstantial, item, status, untyped);
            int expected = 1 + 2 + 13 + 10 + 3 + 5 + 7 + 11;
            int actual = ac.FinalACBonus();
            Assert.AreEqual(expected, actual, 0.001,
                "ACBonus with all args calculating wrong. \n Expected: " + expected + " Got: " + actual);
        }

        [TestMethod]
        public void FinalACBonusforced()
        {
            ACBonus ac = new ACBonus(lev, level, attribute, circumstantial, item, status, untyped);
            ac.Force(forced);
            int expected = 4;
            int actual = ac.FinalACBonus();
            Assert.AreEqual(expected, actual, 0.001,
                "ACBonus with forced value calculating wrong. \n Expected: " + expected + " Got: " + actual);
        }

        [TestMethod]
        public void FinalACBonusMax()
        {
            ACBonus ac = new ACBonus(lev, level, attribute, circumstantial, item, status, untyped);
            ac.MaxArmorBonus(5);
            int expected = 1 + 2 + 5 + 10 + 3 + 5 + 7 + 11;
            int actual = ac.FinalACBonus();
            Assert.AreEqual(expected, actual, 0.001,
                "ACBonus with max armorclass bonsus calculating wrong. \n Expected: " + expected + " Got: " + actual);
        }
    }
}
