using Calculators;

namespace TestCalculator
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
        [TestCase(1, 0, 0)]
        [TestCase(10, 2, 5)]
        [TestCase(100, 10, 10)]
        [TestCase(-10, 2, -5)]
        [TestCase(-10, -2, 5)]
        [TestCase(10, -2, -5)]
        [TestCase(10, 2, 5)]
        [TestCase(7, 1, 7)]
        [TestCase(-8, 4, -2)]
        [TestCase(-12, -3, 4)]
        [TestCase(int.MaxValue, 1, int.MaxValue)]
        [TestCase(int.MinValue, 1, int.MinValue)]
        public void TinhThuong(int x, int y, int z)
        {
            int actual = _math.Thuong(x, y);
            Assert.AreEqual(z, actual);
        }
        [Test]
        [TestCase(0, 0, 0)]
        [TestCase(1, 1, 1)]
        [TestCase(5, 5, 25)]
        [TestCase(10, 2, 20)]
        [TestCase(100, 100, 10000)]
        [TestCase(-1, 1, -1)]
        [TestCase(-5, -5, 25)]
        [TestCase(2, 3, 6)]
        [TestCase(7, 0, 0)]
        [TestCase(-4, 5, -20)]
        [TestCase(-6, -3, 18)]
        [TestCase(int.MaxValue, 1, int.MaxValue)]
        [TestCase(int.MinValue, 1, int.MinValue)]
        public void TinhTich(int x, int y, int z)
        {
            int actual = _math.Tich(x, y);
            Assert.AreEqual(z, actual);
        }

    }
}