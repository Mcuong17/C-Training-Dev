using System;

namespace InNFibonaci
{
    class Program
    {
        static void dayFibo()
        {
            Console.WriteLine("Mời bạn nhập n!");
            int n = int.Parse(Console.ReadLine());
            if(n <= 2)
            {
                Console.WriteLine("n nhập vào phải lớn hơn 2");
                return;
            }
            else
            {
        
            int fn1 = 1;
            int fn2 = 1;
            Console.Write(fn1 + " ");
            Console.Write(fn2 + " ");
            for (int i = 3; i <= n; i++)
            {
                int fn = fn1 + fn2;
                Console.Write(fn + " ");
                 // cộng in ra fn rồi đảo lại vị trí
                fn1 = fn2;
                fn2 = fn;
            }
            }
           
        }
        static void Main(string[] args)
        {
            dayFibo();
        }
    }
}
