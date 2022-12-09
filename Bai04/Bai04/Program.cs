using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int a = 5;
            a += 2;
            Console.WriteLine("a = " + a);
            // nhập vào một số hỏi số đó chẵn hay lẻ
            Console.ReadLine();

            Console.WriteLine("Mời bạn nhập b: ");
            int b;
            b = int.Parse(Console.ReadLine());
            if(b % 2 == 0)
            {
                Console.WriteLine(b +" là số chẵn");
            }
            else
            {
                Console.WriteLine(b + " là số lẻ");
            }
            Console.WriteLine("Mời bạn nhập năm: ");
            int year = int.Parse(Console.ReadLine());
            if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
                Console.WriteLine(year + " là năm nhuần");
            else
                Console.WriteLine(year + " Không là năm nhuần");
            Console.WriteLine("Nhập vào điểm của bạn ");
            double diem;
            diem = int.Parse(Console.ReadLine());
            if(diem > 5)
            {
                Console.WriteLine(diem + "Đậu");
            }
            else 
            {
                Console.WriteLine(diem + " Rớt");
            }

            int d = 7;
            int e = 9;
            int g = d++ - ++e - 5;
            Console.WriteLine("d " + d, "e " + e, "g: " + g);
            int a1 = 5, a2 = 8, a3 = 9;
            int sum = ++a1 - a2++ - --a3 + 2;
            Console.WriteLine("a1={0}, a2 = {1}, a3={2}, sum = {3}", a1, a2, a3, sum);
            Console.ReadLine();
        }
    }
}
