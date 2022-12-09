using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TamGiacCan
{
    internal class Program
    {
        static void tamGiacThuong()
        {
            //*
            //**
            //***
            //****
            //***** sao = i
            Console.WriteLine("Nhập vào chiều cao nguyên dương");
            int n = int.Parse(Console.ReadLine());
            for(int i = 1; i <= n; i++)
            {
                for(int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine(" ");
            }
        }
        static void tamGiacCan()
        {
            //----*   i = 1;
            //---***  i = 3;
            //--***** i = 5;
            //-******* sao = 2*i - 1; kc giảm dần từ k đến n
           
            Console.WriteLine("Nhập vào chiều cao tam giác");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                for(int k = n; k >= i; k--)
                {
                    Console.Write(" ");
                }
                int x = 2 * i - 1;
                // Vòng lặp tạo ra dấu sao
               for(int j = 1; j <= x; j++)
                {
                    Console.Write("*");
                }
                // đến cuối vòng lặp thì in ra xuống dòng
                Console.Write("\n");
            }
           
        }
        static void Main(string[] args)
        {
           
            tamGiacCan();
            Console.ReadLine();
        }
        
    }
}


//Viết chương trình nhập vào n là số nguyên. Hiển thị ra màn hình hình tam giác cân (*) cạnh có độ dài chiều cao là n.
