using System;

namespace HinhChuNhat
{
    class Program
    {
        static void HinhChuNhat()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Mời nhập cạnh x");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Mời nhập cạnh y");
            int y = int.Parse(Console.ReadLine());

            for(int i = 1; i<= y; i++)
            {
                Console.Write("*");
                for(int j = 1; j<= x; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine(" ");
               
            }

            Console.ReadLine();
        }
        static void HinhChuNhatRong()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Mời nhập cạnh x");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Mời nhập cạnh y");
            int y = int.Parse(Console.ReadLine());

            for(int i = 1; i<= y; i++)
            {
               
                for(int j = 1; j<= x; j++)
                {
                    if(i == 1 || i == x || j == 1 || j == y)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine(" ");
            }
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            HinhChuNhat();
            HinhChuNhatRong();
        }
    }
}

/*
 **********
 *        *
 *        *
 *        *
 *        *
 *        *
 **********
 
 */
