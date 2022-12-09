using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XayDungCacLopKeThua
{
    internal class Program
    {
        static void testNhanVien()
        {
            NhanVienChinhThuc teo = new NhanVienChinhThuc();
            teo.Ma = 123;
            teo.Ten = "Nguyễn văn tèo";
            Console.WriteLine("Lương của{0} là ", teo.Ten);
            teo.TinhLuong();

            NhanVienThoiVu ty = new NhanVienThoiVu();
            ty.Ma = 1234;
            ty.Ten = "Nguyễn văn tý";
            Console.WriteLine("Lương của " + ty.Ten + ": ");
            ty.TinhLuong();
        }
        static void testTinhLuong()
        {
            NhanVienChinhThuc teo = new NhanVienChinhThuc();
            Console.Write(teo.TinhLuong(20));
        }
        static void testHinhHoc()
        {
            HinhHoc hh = new HinhHoc(); // tạo đối tượng hh từ lớp cơ sở Hình học
            Console.WriteLine("Diện tích = " + hh.TinhDienTich());
            HinhHoc htron = new HinhTron(); // lớp cơ sở có thể tạo được lớp nhận
            Console.WriteLine("Diện tích hình tròn = " + htron.TinhDienTich());
        }
        static void testHinhChuNhatHinhVuong()
        {
            HinhChuNhat h1 = new HinhChuNhat(4, 10);
            Console.WriteLine("Chu vi = " + h1.ChuVi() + "Diện tích = " + h1.DienTich());
            HinhChuNhat h2 = new HinhVuong(5);
            Console.WriteLine("Chu vi: " + h2.ChuVi() + " Diện tích = " + h2.DienTich());
            HinhVuong h3 = new HinhVuong(6);
            Console.WriteLine("Chu vi: " + h3.ChuVi() + " Diện tích = " + h3.DienTich());
        }
        static void testInterface()
        {
            LamViec A = new NhanVien();
            string result = A.LamViec(" Báo cáo kinh doanh");
            Console.WriteLine(result);
            LamViec B = new SinhVien();
            result = B.LamViec(" Đang học");
            Console.WriteLine(result);
        }
        static void testIsAs()
        {
            List<LamViec> ds = new List<LamViec>();
            NhanVien A = new NhanVien() { Ma = 1, Ten = "Nguyễn Văn A" };
            ds.Add(A);
            SinhVien B = new SinhVien() { Ma = 2, Ten = "Nguyễn Văn B" };
            ds.Add(B);
            ds.Add(new NhanVien() { Ma = 2, Ten = "abc"});
            foreach(LamViec i in ds)
            {
                if(i is NhanVien)
                {
                    NhanVien nv = i as NhanVien;
                    Console.WriteLine(nv.Ten);
                }
                else if(i is SinhVien)
                {
                    SinhVien sv = i as SinhVien;
                    Console.WriteLine(sv.Ten);
                }
            }
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //testNhanVien();
            //testTinhLuong();
            //testHinhHoc();
            //testHinhChuNhatHinhVuong();
            //testInterface();
            testIsAs();
            Console.ReadLine();
        }
        
    }
}

/*
    * KẾ THỪA
    - Trong một mô tả thực tế: Cách phát hiện được mô hình lớp mà ở đó có tính kế thừa
    + Tổng quát hóa: Những cái gì chung chung, các đặc tính chung thì viết trong tổng quát hóa
    + Chuyên biệt hóa: những đặc tính riêng của đối tượng, nằm trong những lớp chuyên biệt

    - Kĩ thuật khai báo kế thừa: 
    + Cần có: Lớp cơ sở để các lớp khác kế thừa và lớp con để nhận các đặc điểm của lớp cơ sở
    + Khai báo:
        class LopNhan: LopCoSo
    + Contructor không được kế thừa,các lớp con truy cập bằng từ khóa base
    + base: truy cập đến các thành phần của lớp cơ sở(contructor, thuộc tính, phương thức), mức truy cập: public, protected
    + new: Dùng để khai báo phương thức ở lớp nhận(lớp con) khi đã có phương thức cùng tên
        ở lớp cơ sở(lớp cha)
    - Overiding Methods
    + Một tập các lớp có mối quan hệ cha con có các phương thức giống singnature y xì(nd phương thức khác nhau)
    + Giúp LTV có thể định nghĩa cách hành xử khác nhau ứng với các đối tượng khác nhau
    nhưng ứng với cùng một tên phương thức
    
    * ĐA HÌNH:
    Lớp kế thừa từ lớp cơ sở(lớp cha) và có thêm các đặc tính riêng biệt, dễ dàng quản lý code do chỉ sửa ở lớp cơ sở
    + Đa hình có thể được tạo ra từ lớp kế thừa lớp hoặc từ interface
    + Từ khóa: 
        Virtual: Khai báo trong lớp cơ sở, cho biết thành phần có thể nạp chồng, có thể override
        Override: Khai báo trong lớp nhận, cho biết thành phần đó được nạp chồng, khai báo
                trong lớp con, định nghĩa lại phương thức đó
    + Khi tham chiếu đến đối tượng
     Nếu đối tượng là lớp cơ sở -> phương thức vitual của lớp cơ sở được thực hiện
     Nếu đối tượng là lớp nhận -> phương thức override của lớp nhận được thực hiện
    + Interface: là một giao ước, khi một lớp thực hiện interface thì cần tuân thủ theo
        đúng những gì interface đo quy định -> định nghĩa ra một rule
        Thành phần interface: Property,Method, Event
        ++ Khai báo interface TenIntercafe {...các thành phần}
        ++ Mức truy xuất: Public
        ++ Các phương thức chỉ có khai báo ko có phần thân, các PT trừu tượng
        ++ Interface có thể kế thừa, 
        ++ Một lớp có thể thực hiện một hoặc nhiều interface
        ++ Khi thực hiện interface, thì lớp đó phải thực hiện đầy đủ những thành phần mà
            interface mô tả
        ++ is và as: is ktra xem đối tượng đó đang thực hiện interface nào(true/false)
                     as: thực hiện chuyển đổi sang interface, nếu đối tượng ko thực hiện interface
                     thì return null
 */
