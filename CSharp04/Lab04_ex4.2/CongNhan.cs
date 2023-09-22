using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04_ex4._2
{
    internal class CongNhan:NhanVien
    {
        private int SoLuongSanPham;
        public CongNhan(string Ten, string DiaChi, int SoLuongSanPham):base(Ten, DiaChi)
        {
            this.SoLuongSanPham = SoLuongSanPham;
        }

        public override void HienThi()
        {
            Console.WriteLine("Ten: " + Ten);
            Console.WriteLine("Dia chi: " + DiaChi);
            Console.WriteLine("So luong san pham: " + SoLuongSanPham);
        }

        public override double TinhLuong()
        {
            return SoLuongSanPham;
        }
    }
}
