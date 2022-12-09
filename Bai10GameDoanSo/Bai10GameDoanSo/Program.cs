using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai10GameDoanSo
{
    internal class Program
    {
        static void Choi()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Random rd = new Random();
            int soCuaMay = rd.Next(501);
            int soCuaNguoi = int.Parse(Console.ReadLine());
            int soLanDoan = 0;
            Console.WriteLine("Máy đã đưa ra một số từ [0..500] hãy đoán");
            while(true)
            {
                soLanDoan++;
                Console.WriteLine("Bạn đã đoán lần thứ {0}", soLanDoan)
                if(soCuaMay == soCuaNguoi)
                {
                    Console.WriteLine("Chúc mừng bạn đã đoán chính xác!!!");
                    break;
                }
                else if(soCuaMay < soCuaNguoi)
                {
                    Console.WriteLine("Số của bạn > số của máy");
                }
                else if(soCuaMay > soCuaNguoi)
                {
                    Console.WriteLine("Số của bạn < số của máy");
                }
                else if(soLanDoan == 7)
                {
                    Console.WriteLine("Bạn đã đoán quán 7 lần, GAME OVER!!");
                    Console.WriteLine("Số đúng là: {0}", soCuaMay);
                    break;
                }
            }
        }
            
        }
        static void Main(string[] args)
        {
        
        }
    }
}
