using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XayDungCacLopKeThua
{
    public class HinhChuNhat
    {
        public int canhA;
        public int canhB;
       
        public HinhChuNhat(int canhA, int canhB)
        {
            this.canhA = canhA;
            this.canhB = canhB;
        }
        public virtual int DienTich()
        {
            return canhA * canhB;
        }
        public virtual int ChuVi()
        {
            return (canhA + canhB) * 2;
        }
    }
}
