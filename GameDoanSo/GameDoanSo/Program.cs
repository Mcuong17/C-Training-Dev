using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDoanSo
{
    internal class Program
    {
        static void Play()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Random random = new Random();
            int soCuamay = random.Next(21);
            int soLanDem = 0;
            Console.WriteLine("Máy đã tạo ra số từ [0...21] hãy đoán số đó");
            while(true)
            {
                soLanDem++;
                int soCuaNguoi = int.Parse(Console.ReadLine());
                Console.WriteLine("Bạn đã đoán {0} lần còn lại {1} lần đoán", soLanDem, 7 - soLanDem);
                if(soLanDem > 0 && soCuaNguoi > 0)
                {
                    if(soCuamay == soCuaNguoi)
                    {
                        Console.WriteLine("Chúc mừng bạn đã đoán trúng!!!!!");
                        break;
                    }
                    if(soCuaNguoi < soCuamay)
                    {
                        Console.WriteLine("Bạn nhập số < số của máy, thử lại lần nữa nào");
                    }
                    if(soCuaNguoi > soCuamay)
                    {
                        Console.WriteLine("Bạn nhập số > số của máy, thử lại lần nữa nào");
                    }
                }
                if(soLanDem == 7)
                {
                    Console.WriteLine("Bạn đã đếm 7 lần, Game Over!!");
                    Console.WriteLine("Số đúng là {0}", soCuamay);
                    break;
                }
               
            }
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            while(true)
            {
                Play();
                Console.WriteLine("bạn muốn chơi tiếp không(yes/no)");
                string hoi = Console.ReadLine();
                if(hoi == "no")
                {
                    break;
                }
            }
        }
    }
}
