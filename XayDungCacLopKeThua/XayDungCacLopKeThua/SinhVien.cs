using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XayDungCacLopKeThua
{
    public class SinhVien:LamViec
    {
        public int Ma { get; set; }
        public string Ten { get; set; }
        public string LamViec(string mota)
        {
            string s = "Sinh viên đang" + mota;
            return s;
        }
    }
}
