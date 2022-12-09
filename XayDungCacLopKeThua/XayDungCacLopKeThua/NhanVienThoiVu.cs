using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XayDungCacLopKeThua
{
    public class NhanVienThoiVu:NhanVien
    {
        public new void TinhLuong()
        {
            base.TinhLuong();// Truy xuất đến phương thức của lớp cha
                Console.WriteLine("Đây là PT tính lương của NhanVienThoiVu");
            
        }
    }
}
