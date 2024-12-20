using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace de2
{
    public class SanPhamThanhLy:SanPham
    {
        private double _donGia;
        private int _soLuong;

        public double DonGia { get => _donGia; set => _donGia = value; }
        public int SoLuong { get => _soLuong; set => _soLuong = value; }
        public SanPhamThanhLy() { }
        public SanPhamThanhLy (string maSanPham, string tenSanPham, double donGia, int soluong)
            :base(maSanPham, tenSanPham) 
        {
            this.DonGia = donGia;
            this.SoLuong = soluong;
        }
        public override double TinhTongTien()
        {
            return SoLuong * DonGia;
        }
        public override string ToString()
        {
            return base.ToString() + $"\t Don gia {DonGia}, \t So Luong{SoLuong}";
        }
    }
}
