using System;

namespace DaoNguocSo
{
    class Program
    {
        static void DaoNguocSo()
        {
            Console.WriteLine("Hello World!");
            int a = 123;
            int b = 0;
            while(a > 0)
            {
                int du = a % 10; // du = 3, du = 2, du = 1
                b = b * 10 + du; // b = 0 * 10 + 3 = 3, b = 2, b = 1
                a = a / 10; // a = 12, a = 1, a = 0
            }
            Console.WriteLine(b);
        }
        static void Main(string[] args)
        {
            DaoNguocSo();
        }
    }
}
