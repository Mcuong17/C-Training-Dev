using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int soLuong;
            double diemToan = 9.5;
            int x = 1;
            string name = "Trần Duy Thanh";
            string ten = "Ông Thanh";
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Điểm Toán = {0}", diemToan);
            Console.WriteLine("Tên = {0}, điểm = {1}", name, diemToan);
            double d = 1 / 2;
            Console.WriteLine("d = {0}/{1} = {2}",1,2,d);
            double d2 = (double)1 / 2;// ép kiểu số nguyên sang kiểu số thực sử dụng (double)
            Console.WriteLine("d2 = {0}/{1} = {2}",1,2,d2);
            double d3 = 1.0 / 2;// ép kiểu trực tiếp
            Console.WriteLine("d3 = {0}/{1} = {2}", 1, 2, d3);
            var t = 10;
            Console.WriteLine("Kiểu của t = {0}", t.GetType().ToString());
            const double PI = 3.14;// hằng số không thay đổi, nên viết hoa
            Console.WriteLine("PI = {0}",PI);
            Console.ReadLine();
        }
    }
}
