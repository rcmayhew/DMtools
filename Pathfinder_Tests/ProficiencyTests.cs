using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pathfinder;

namespace Pathfinder_Tests
{
    [TestClass]
    public class ProficiencyTests
    {
        int level = 7;
        [TestMethod]
        public void UntrainedTest()
        {
            int expected = level;
            Proficiency proficiency = new Proficiency(Levels.untrained, this.level);
            int actual = proficiency.ProficiencyBonus();
            Assert.AreEqual(expected, actual, 0.001, "Untrained Bonus not calculating correctly");

        }
        [TestMethod]
        public void TrainedTest()
        {
            int expected = 9;
            Proficiency proficiency = new Proficiency(Levels.trained, this.level);
            int actual = proficiency.ProficiencyBonus();
            Assert.AreEqual(expected, actual, 0.001, "Trained Bonus not calculating correctly");

        }

        [TestMethod]
        public void ExpertTest()
        {
            int expected = 11;
            Proficiency proficiency = new Proficiency(Levels.expert, this.level);
            int actual = proficiency.ProficiencyBonus();
            Assert.AreEqual(expected, actual, 0.001, "Expert Bonus not calculating correctly");

        }
        [TestMethod]
        public void MasterTest()
        {
            int expected = 13;
            Proficiency proficiency = new Proficiency(Levels.master, this.level);
            int actual = proficiency.ProficiencyBonus();
            Assert.AreEqual(expected, actual, 0.001, "Master Bonus not calculating correctly");

        }
        [TestMethod]
        public void LegendarTest()
        {
            int expected = 15;
            Proficiency proficiency = new Proficiency(Levels.legendary, this.level);
            int actual = proficiency.ProficiencyBonus();
            Assert.AreEqual(expected, actual, 0.001, "Legendary Bonus not calculating correctly");

        }
    }
}
