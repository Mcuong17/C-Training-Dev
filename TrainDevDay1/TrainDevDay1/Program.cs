using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainDevDay1
{
    internal class Program
    {
        static void tinhTong()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập vào số phần tử trong dãy số");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập các số");
            int[] arr = new int[n];
            int tong = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
                tong += arr[i];
            }
            Console.WriteLine("tổng các số: {0}",tong);
            Console.ReadKey();
        } 
        static void Main(string[] args)
        {
            tinhTong();
        }
    }
}
