using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace de2
{
    public class SanPham
    {
        private string _maSanPham;
        private string _tenSanPham;

        public string MaSanPham { get => _maSanPham; set => _maSanPham = value; }
        public string TenSanPham { get => _tenSanPham; set => _tenSanPham = value; }
        public virtual double TinhTongTien(){ return 0; }
        public SanPham() { }
        public SanPham(string maSanPham, string tenSanPham)
        {
            this.MaSanPham = maSanPham;
            this.TenSanPham = tenSanPham;
        }
        public override string ToString()
        {
            return $"Ma san pham {MaSanPham} \t, Ten san pham {TenSanPham}";
        }
        public override bool Equals(object obj)
        {
            if (obj is SanPham other)
            {
                return MaSanPham == other.MaSanPham && TenSanPham == other.TenSanPham;
            }
            return false;
        }
    }
}
