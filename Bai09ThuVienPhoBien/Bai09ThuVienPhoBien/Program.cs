using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai09ThuVienPhoBien
{
    internal class Program
    {
        static void TestToanHoc()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Mời nhập vào số a: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Căn bậc hai của {0} = {1}",a, Math.Sqrt(a));
            Console.WriteLine("Mời nhập vào số b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0}^{1} = {2}", a, b, Math.Pow(a, b));
            Console.WriteLine("Mời nhập vào một góc: ");
            int goc = Convert.ToInt32(Console.ReadLine());
            double radian = Math.PI * goc / 180;
            Console.WriteLine("sin({0}) = {1}", goc, Math.Sin(radian));
            Console.WriteLine("cos({0}) = {1}", goc, Math.Cos(radian));
            Console.WriteLine("tan({0}) = {1}", goc, Math.Tan(radian));
            Console.WriteLine("Cotan({0}) = {1}", goc,1/ Math.Tan(radian));

            double x = 8.623234;
            Console.WriteLine("x ban đầu = {0}", x);
            Console.WriteLine("x sau khi làm tròn = {0}", Math.Round(x, 2));
            Console.ReadLine();
        }
        static void TestRandom()
        {
            // hãy xuất số ngẫu nhiên trong đoạn từ [0 -> 100]
            Console.OutputEncoding = Encoding.UTF8;
            Random rd = new Random();
            int x = rd.Next(101); // xuất số ngẫu nhiên từ 0 đến 100, chạy từ 0 đến 100
            Console.WriteLine("Máy ra số ngẫu nhiên = {0}", x);

            double d = rd.NextDouble();// chạy từ 0 đến tiệm cận 1
            Console.WriteLine("Máy ra số ngẫu nhiên = {0}", Math.Round(d * 10)); // [0 10)

            int y = rd.Next(50, 150); // [50..149);
            Console.ReadLine();
        }
        static void TestDateTime()
        {
            Console.OutputEncoding = Encoding.UTF8;
            DateTime d= new DateTime(1970,1,27);
            Console.WriteLine(d.ToString("dd/MM/yyyy"));

            Console.WriteLine("Mời bạn nhập vào ngày sinh: ");
            int day = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Mời bạn nhập vào tháng sinh: ");
            int month = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Mời bạn nhập vào năm sinh: ");
            int year = Int32.Parse(Console.ReadLine());
            DateTime dt = new DateTime(year, month, day);
            Console.WriteLine(dt.Day);
            Console.ReadLine();
        }
        static void Main(string[] args)
        {

            //TestToanHoc();
            //TestRandom();
            TestDateTime();
        }
    }
}
