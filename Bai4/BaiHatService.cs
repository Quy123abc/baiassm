using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    public class BaiHatService
    {
        public List<BaiHat> _baiHats = new List<BaiHat>();

        public void AddBaiHat(BaiHat baiHat)
        {
            if (baiHat == null)
            {
                throw new ArgumentNullException(nameof(baiHat));
            }
            if (_baiHats.Exists(b => b.Id == baiHat.Id))
            {
                throw new InvalidOperationException("Bài hát với ID này đã tồn tại.");
            }

            _baiHats.Add(baiHat);
        }

        public void RemoveBaiHat(string id)
        {
            var baiHat = _baiHats.Find(b => b.Id == id);
            if (baiHat != null)
            {
                _baiHats.Remove(baiHat);
            }
        }

        public BaiHat GetBaiHat(string id)
        {
            return _baiHats.Find(b => b.Id == id);
        }
    }
}
