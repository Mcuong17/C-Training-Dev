using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XayDungCacLopKeThua
{
    public class NhanVienChinhThuc:NhanVien
    {
        public new void TinhLuong() // dùng new để tạo mới PT nếu PT trong class cha đã có
        {
            base.TinhLuong();// base tương đương với gọi class NhanVien
            Console.WriteLine("Đây là PT tính lương của NhanVienChinhThuc");
        }
        public override int TinhLuong(int soNgayLuong)
        {
            if(soNgayLuong == 20)
            {
                return 10000;
            }
            else
            {
            return base.TinhLuong(soNgayLuong);

            }
        }
    }
}
