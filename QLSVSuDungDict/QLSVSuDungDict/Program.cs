using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace QLSVSuDungDict
{
    internal class Program
    {
    static Dictionary<int, string> dict = new Dictionary<int, string>();
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            try
            {
                while (true)
                {
                    menuQuanLySinhVien();
                    Console.WriteLine("Tiếp tục phần mềm(y/n)");
                    string luaChon = Console.ReadLine();
                    if (luaChon == "n")
                    {
                        break;
                    }
                }
                Console.WriteLine("BYE BYE!!");
                Console.ReadLine();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Có lỗi gì đó", ex.Message);
            }
           
        }

        private static void menuQuanLySinhVien()
        {
            Console.WriteLine("******************************");
            Console.WriteLine("* PHẦN MỀM QUẢN LÝ SINH VIÊN  *");
            Console.WriteLine("*                             *");
            Console.WriteLine("* [Mời Lựa chọn các chức năng]*");
            Console.WriteLine("*                             *");
            Console.WriteLine("*  1. Thêm sinh viên          *");
            Console.WriteLine("*  2. Sửa sinh viên           *");
            Console.WriteLine("*  3. Xóa sinh viên           *");
            Console.WriteLine("*  4. Tra cứu sinh viên       *");
            Console.WriteLine("*  5. Xem danh sách sinh viên *");
            Console.WriteLine("*******************************");
            Console.WriteLine("-------------------------------");
            int luaChon = int.Parse(Console.ReadLine());
            switch(luaChon)
            {
                case 1:
                    themSinhVien();
                    break;
                case 2:
                    suaSinhVien();
                    break;
                case 3:
                    xoaSinhVien();
                    break;
                case 4:
                    traCuuSinhVien();
                    break;
                case 5:
                    xemDanhSachSinhVien();
                    break;
                default:
                    Console.WriteLine("Mời nhập đúng lựa chọn");
                    break;
            }
        }

        private static void xemDanhSachSinhVien()
        {
            foreach(KeyValuePair<int,string> i in dict)
            {
                Console.WriteLine("Mã sinh viên [{0}]  Tên sinh viên [{1}]", i.Key, i.Value);
            }
        }

        private static void traCuuSinhVien()
        {
           Console.WriteLine("Nhập mã sinh viên muốn tra cứu");
            int msv = int.Parse(Console.ReadLine());
            if(dict.ContainsKey(msv))
            {
                Console.WriteLine("Mã sinh viên [{0}], họ tên [{1}]", msv, dict[msv]);
            }
            else
            {
                Console.WriteLine("Không tìm thấy mã sinh viên này");
            }
        }

        private static void xoaSinhVien()
        {
            Console.WriteLine("Nhập mã sinh viên muốn xóa");
            int msv = int.Parse(Console.ReadLine());
            if(dict.ContainsKey(msv))
            {
                dict.Remove(msv);
                Console.WriteLine("Xóa thành công msv [{0}]", msv);
            }
            else
            {
                Console.WriteLine("Không tìm thấy msv muốn xóa");
            }
        }

        private static void suaSinhVien()
        {
            Console.WriteLine("Nhập mã sinh viên muốn sửa");
            int msv = int.Parse(Console.ReadLine());
            if(dict.ContainsKey(msv))
            {
                Console.WriteLine("Nhập tên thay đổi của sinh viên");
                string name = Console.ReadLine();
                dict[msv] = name;
                Console.WriteLine("Sửa thành công");
            }
        }

        private static void themSinhVien()
        {
            Console.WriteLine("Mời nhập mã sinh viên");
            int msv = int.Parse(Console.ReadLine());
            if(dict.ContainsKey(msv)) {
                Console.WriteLine("Đã tồn tại mã sv [{0}] trong phần mềm",msv);
            }
            else
            {
                Console.WriteLine("Mời nhập họ tên sinh viên");
                string name = Console.ReadLine();
                dict.Add(msv, name);
                Console.WriteLine("Thêm thành công sv[{0}] có mã sv [{1}] vào phần mềm", name, msv);
            }
        }
    }
}
