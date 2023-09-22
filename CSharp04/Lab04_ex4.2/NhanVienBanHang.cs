using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04_ex4._2
{
    internal class NhanVienBanHang:NhanVien
    {
        private int SoLuongBanDuoc;

        public NhanVienBanHang(string Ten, string DiaChi, int soLuongBanDuoc):base(Ten, DiaChi)
        {
            SoLuongBanDuoc = soLuongBanDuoc;
        }

        public override void HienThi()
        {
            Console.WriteLine("Ten: " + Ten);
            Console.WriteLine("Dia chi: " + DiaChi);
            Console.WriteLine("So luong ban duoc: " + SoLuongBanDuoc);
        }

        public override double TinhLuong()
        {
            return SoLuongBanDuoc;
        }
    }
}
