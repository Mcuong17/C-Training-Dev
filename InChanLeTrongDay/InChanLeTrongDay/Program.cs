using System;

namespace InChanLeTrongDay
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhập n: ");
            int n = int.Parse(Console.ReadLine());
            for(int i = 1; i <= n; i++)
            {
                if(i %2 == 0)
                {
                   
                    Console.WriteLine(i + " ");
                }
                else if (i % 2 != 0)
                {

                    Console.WriteLine(i + " ");
                }

            }
            Console.ReadLine();
        }
    }
}
