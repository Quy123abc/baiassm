using Bai3;

namespace TestBai3
{
    public class Tests
    {
        private Class1 _math;

        [SetUp]
        public void Setup()
        {
            _math = new Class1();
        }
        [Test]
        [TestCase(0, "F")]
        [TestCase(40, "F")]
        [TestCase(41, "D")]
        [TestCase(60, "D")]
        [TestCase(61, "C")]
        [TestCase(70, "C")]
        [TestCase(71, "B")]
        [TestCase(80, "B")]
        [TestCase(81, "A")]
        [TestCase(100, "A")]
        public void GetGrade_ValidScores_ReturnsExpectedGrade(int score, string expectedGrade)
        {
            string actualGrade = _math.GetGrade(score);
            Assert.AreEqual(expectedGrade, actualGrade);
        }

        
    }
}