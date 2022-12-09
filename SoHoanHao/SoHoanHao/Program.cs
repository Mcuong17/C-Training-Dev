using System;

namespace SoHoanHao
{
    class Program
    {
        static void SoHoanHao()
        {
            Console.WriteLine("Nhập vào số n");
            int n = int.Parse(Console.ReadLine());
            if(n < 0)
            {
                Console.WriteLine("Số nhập phải lớn hơn 0");
                return;
            }
            bool laSoHoanHao = false;
            int tong = 0;
            for(int i = 1;i < n; i++)
            {
                if(n % i == 0)
                {
                    tong = tong + i;
                    if(tong == n)
                    {
                        laSoHoanHao = true;
                        break;
                    }
                }
            }
            if(laSoHoanHao)
            {
                Console.WriteLine(n + " Là số hoàn hảo");
            }
            else
            {
                Console.WriteLine(n + "Không là số hoàn hảo");
            }
        }
        static void InSoHoanHao(int n)
        {
            int tong = 0;
            for(int i = 1; i < n; i++)
            {
                if(n % i ==0)
                {
                    tong += i;
                    if(tong == n)
                    {
                        Console.Write(i + " ");
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            SoHoanHao();
            for(int i = 1; i < 1001; i++)
            {
                InSoHoanHao(i);
            }
        }
    }
}
