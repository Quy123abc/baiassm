using Bai1;

namespace TestBai1
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
        [TestCase(0, 1, 0)]
        [TestCase(10, 2, 5)]
        [TestCase(100, 10, 10)]
        [TestCase(-10, 2, -5)]
        [TestCase(-10, 0, 0)]
        [TestCase(10, -2, -5)]
        [TestCase(10, 2, 5)]
        [TestCase(7, 1, 7)]
        [TestCase(-8, 0, -2)]
        [TestCase(-12, -3, 4)]
        [TestCase(int.MaxValue, 1, int.MaxValue)]
        [TestCase(int.MinValue, 1, int.MinValue)]

        public void TinhThuong(int a, int b, int c)
        {
            var result = _math.Thuong(a, b);
            Assert.That(result, Is.EqualTo(c));
        }
    }
}