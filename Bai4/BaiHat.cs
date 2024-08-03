namespace Bai4
{
    public class BaiHat
    {
        public string Id { get; set; }
        public string Ten { get; set; }
        public string TenCaSi { get; set; }
        public int DoDai { get; set; }
        public string TenNhacSi { get; set; }
        public BaiHat() { }

        public BaiHat(string id, string ten, string tenCaSi, int doDai, string tenNhacSi)
        {
            Id = id;
            Ten = ten;
            TenCaSi = tenCaSi;
            DoDai = doDai;
            TenNhacSi = tenNhacSi;
        }
    }
}
