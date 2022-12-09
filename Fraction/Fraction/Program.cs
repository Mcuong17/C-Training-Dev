using System;

namespace Fraction
{
    class Program
    {
        static void phanSo()
        {
            //Khởi tạo đối tượng với contructor có tham số
           Fraction phanso1 = new Fraction(10, 2);
            phanso1.Info();
            Fraction phanso2 = new Fraction();
            phanso2.Info();
            phanso1.TuSo = 11; // Gọi đến PT set nằm trong thuộc tính TuSo
            phanso1.MauSo = 3;
            phanso1.Info();

        }

        static void nhapPhanSo()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Fraction phanSo3 = new Fraction();
            Console.WriteLine("Mời nhập tử số");
            phanSo3.TuSo = int.Parse(Console.ReadLine());
            Console.WriteLine("Mời nhập mẫu số");
            phanSo3.MauSo = int.Parse(Console.ReadLine());
            phanSo3.Info();
            phanSo3.RutGonPhanSo();
        }

       

        static void Main(string[] args)
        {
            //phanSo();
            nhapPhanSo();
            Console.ReadKey();
        }
    }
}
