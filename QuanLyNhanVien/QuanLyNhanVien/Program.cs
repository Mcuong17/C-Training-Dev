using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanVien
{
    internal class Program
    {
        static List<PhongBan> dsPhongBan = new List<PhongBan>();
        static void testQLNV()
        {
            PhongBan phongNhanSu = new PhongBan();
            phongNhanSu.MaPhongBan = 1;
            phongNhanSu.TenPhongBan = "Phòng Nhân Sự";
            dsPhongBan.Add(phongNhanSu);

            PhongBan phongKeToan = new PhongBan();
            phongKeToan.MaPhongBan = 2;
            phongKeToan.TenPhongBan = "Phòng Kế Toán";
            dsPhongBan.Add(phongKeToan);

            NhanVien teo = new NhanVien();
            teo.MaNhanVien = 112;
            teo.TenNhanVien = "Tý";
            teo.ChucVu = LoaiChucVu.TRUONG_PHONG;
            phongNhanSu.ThemNhanVien(teo);

            NhanVien ty = new NhanVien();
            ty.MaNhanVien = 113;
            ty.TenNhanVien = "Tèo";
            ty.ChucVu = LoaiChucVu.NHAN_VIEN;
            phongNhanSu.ThemNhanVien(ty);

            NhanVien bin = new NhanVien();
            bin.MaNhanVien = 114;
            bin.TenNhanVien = "Nguyễn Văn Bin";
            bin.ChucVu = LoaiChucVu.PHO_PHONG;
            phongKeToan.ThemNhanVien(bin);

            Console.WriteLine("Xuất toàn bộ nhân viên");
            foreach(PhongBan phongBan in dsPhongBan)
            {
                Console.WriteLine(phongBan.TenPhongBan);
               phongBan.XuatToanBoNhanVien();
            }

            NhanVien old = phongKeToan.TimNhanVien(114);
            if(old != null)
            {
                old.TenNhanVien = "Nguyễn Hoàng Nam";
            }
           
            Console.WriteLine("Danh sách nhân viên sau khi sửa là: ");
            foreach(PhongBan phongBan in dsPhongBan)
            {
                Console.WriteLine(phongBan.TenPhongBan);
                phongBan.XuatToanBoNhanVien();
            }

            if (phongNhanSu.XoaNhanVien(115) == false)
            {
                Console.WriteLine("Không tìm thấy mã nhân viên để xóa");
            }
            else
            {
            Console.WriteLine("Danh sách nhân viên sau khi xóa là: ");
            foreach (PhongBan phongBan in dsPhongBan)
            {
                Console.WriteLine(phongBan.TenPhongBan);
                phongBan.XuatToanBoNhanVien();
            }
            }

            Console.WriteLine("Danh sách nhân viên PNS");
            phongNhanSu.XuatToanBoNhanVien();
            phongNhanSu.SapXep();
            Console.WriteLine("Danh sách nhân viên PNS sau khi sắp xếp");
            phongNhanSu.XuatToanBoNhanVien();   
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            testQLNV();
            Console.ReadKey();
        }
    }
}
