using System;

namespace SoNguyenTo
{
    class Program
    {
        static void SoNguyenTo()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Nhập vào n: ");
            int n = int.Parse(Console.ReadLine());
            bool laSoNguyenTo = true;
            if(n <= 1)
            {
                Console.WriteLine("Số NT phải lớn hơn 1");
                return;
            }
            for(int i = 2; i < Math.Sqrt(n); i++)
            {
                if(n % i == 0)
                {
                    laSoNguyenTo = false;
                    Console.WriteLine(n + " Không là SNT");
                    break;
                }
            }
            if(laSoNguyenTo)
            {
                Console.WriteLine(n + "là SNT");
            }
            Console.ReadLine();
        }
        static bool LaSoNguyenTo(int n)
        {

            for (int i = 2; i < Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
           
            for(int i = 2;i < 1001;i++)
            {
                if(LaSoNguyenTo(i))
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine("\n");
            SoNguyenTo();
        }
    }
}
