using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai06
{
    internal class Program
    {
        static void Main(string[] args)
        {  
            Console.OutputEncoding = Encoding.UTF8;
            double diem;
            Console.WriteLine("Mời nhập vào điểm: ");
            diem = double.Parse(Console.ReadLine());
            string ketQua = diem >= 5 ? "Đậu" : "Rớt";
            Console.WriteLine("điểm = {0} ==> {1}", diem, ketQua);
            /*if (diem < 5)
            {
                Console.WriteLine("Rớt");
            }
            else
                Console.WriteLine("Đậu");*/
            Console.WriteLine("Nhập vào a: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập vào b: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập vào ký tự +,-,*,/ : ");
            char kyTu = (Console.ReadLine())[0];// lấy ký tự đầu tiên
            switch(kyTu)
            {
                case '+':
                    Console.WriteLine("{0} + {1} = {2}",a,b, a + b);
                    break;
                case '-':
                    Console.WriteLine("{0} - {1} = {2}", a, b, a - b);
                    break;
                case '*':
                    Console.WriteLine("{0} x {1} = {2}", a, b, a * b);
                    break;
                case '/':
                    Console.WriteLine("{0} : {1} = {2}", a, b,(double)a/b);
                    break;
                default:
                    Console.WriteLine("Lỗi nhập");
                    break;
            }
            Console.ReadLine();
        }
    }
}
