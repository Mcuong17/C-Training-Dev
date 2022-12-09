using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanVien
{
    public class PhongBan
    {
        private List<NhanVien> dsNhanVien = new List<NhanVien>();
        public int MaPhongBan { get; set; }
        public string TenPhongBan { get; set; }
        public NhanVien TruongPhong { get; set; }
        
        public bool ThemNhanVien(NhanVien nv) //PT đưa nhân viên vào phòng ban
        {
            bool trungNhanVien = false;
            foreach(NhanVien Oldnv in dsNhanVien)
            {
                if(Oldnv.MaNhanVien == nv.MaNhanVien)
                {
                    trungNhanVien = true;
                    break;
                }
                if(trungNhanVien == true)
                {
                    return false;
                }
            }
            nv.Phong = this;
            dsNhanVien.Add(nv);
            return true;
        }
        public void XuatToanBoNhanVien()
        {
            foreach(NhanVien nv in dsNhanVien)
            {
                Console.WriteLine(nv);
            }
        }
        public NhanVien TimNhanVien(int maNv) // Sửa là tìm kiếm và gán lại
        {
            foreach(NhanVien old in dsNhanVien)
            {
                if(old.MaNhanVien == maNv)
                {
                    return old;
                }
            }
            return null;
        }
        public bool XoaNhanVien(int maNV)
        {
            NhanVien nv = TimNhanVien(maNV);
            if(nv == null)
            {
                return false;
            }
            dsNhanVien.Remove(nv);
            return true;
        }
        public int compare(NhanVien nv1, NhanVien nv2)
        {
            return string.Compare(nv1.TenNhanVien, nv2.TenNhanVien, true);
        }
        public void SapXep()
        {
            dsNhanVien.Sort(compare);
        }
    }
}
