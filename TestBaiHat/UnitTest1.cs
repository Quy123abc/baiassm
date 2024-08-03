using Bai4;
using NUnit.Framework;
using System;
using System.Linq;

namespace TestBaiHat
{
    [TestFixture]
    public class BaiHatServiceTests
    {
        private BaiHatService baiHatService;

        [SetUp]
        public void Setup()
        {
            baiHatService = new BaiHatService();
        }

        [Test]
        [TestCase("1", "Song1", "Artist1", 180, "Composer1")]
        [TestCase("2", "Song2", "Artist2", 200, "Composer2")]
        [TestCase("3", "Song3", "Artist3", 220, "Composer3")]
        [TestCase("4", "Song4", "Artist4", 240, "Composer4")]
        [TestCase("5", "Song5", "Artist5", 260, "Composer5")]
        public void Test_ThemBaiHat(string id, string ten, string tenCaSi, int doDai, string tenNhacSi)
        {
            var baiHat = new BaiHat(id, ten, tenCaSi, doDai, tenNhacSi);
            baiHatService.AddBaiHat(baiHat);
            Assert.Contains(baiHat, baiHatService._baiHats);
        }

        [Test]
        [TestCase("1", "Song1", "Artist1", 180, "Composer1")]
        [TestCase("2", "Song2", "Artist2", 200, "Composer2")]
        [TestCase("3", "Song3", "Artist3", 220, "Composer3")]
        [TestCase("4", "Song4", "Artist4", 240, "Composer4")]
        [TestCase("5", "Song5", "Artist5", 260, "Composer5")]
        public void Test_XoaBaiHat(string id, string ten, string tenCaSi, int doDai, string tenNhacSi)
        {
            var baiHat = new BaiHat(id, ten, tenCaSi, doDai, tenNhacSi);
            baiHatService.AddBaiHat(baiHat);
            baiHatService.RemoveBaiHat(id);
            var deletedBaiHat = baiHatService._baiHats.FirstOrDefault(b => b.Id == id);
            Assert.IsNull(deletedBaiHat);
        }

        [Test]
        public void Test_ThemBaiHat_ThrowsException_IfIdExists()
        {
            var baiHat1 = new BaiHat("1", "Song1", "Artist1", 180, "Composer1");
            baiHatService.AddBaiHat(baiHat1);

            var baiHat2 = new BaiHat("1", "Song2", "Artist2", 200, "Composer2");
            Assert.Throws<ArgumentException>(() => baiHatService.AddBaiHat(baiHat2));
        }

        [Test]
        [TestCase(1)]
        [TestCase(100)]
        [TestCase(1000)]
        public void Test_ThemBaiHat_DoDaiPositive(int doDai)
        {
            var baiHat = new BaiHat("6", "Song6", "Artist6", doDai, "Composer6");
            baiHatService.AddBaiHat(baiHat);
            Assert.Contains(baiHat, baiHatService._baiHats);
        }

        [Test]
        [TestCase(0)]
        [TestCase(-1)]
        [TestCase(-100)]
        public void Test_ThemBaiHat_DoDaiNotPositive(int doDai)
        {
            var baiHat = new BaiHat("7", "Song7", "Artist7", doDai, "Composer7");
            Assert.Throws<ArgumentException>(() => baiHatService.AddBaiHat(baiHat));
        }
    }
}
