using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XayDungCacLopKeThua
{
    public class HinhVuong:HinhChuNhat
    {
        public HinhVuong(int canhA):base(canhA, canhA) // kế thừa contructor
        {
           
        }
        public override int DienTich()
        {
            return base.DienTich();// kế thừa tính diện tích nhưng contructor đã thay đổi thành 2 cạnh giống nhau
        }
        public override int ChuVi()
        {
            return base.ChuVi();
        }
    }
}
