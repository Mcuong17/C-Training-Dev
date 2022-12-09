using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai11Debug
{
    internal class Program
    {
        static string GiaiPTBacHai(int a, int b, int c)
        {
            if(a==0)
            {
                if(b==0 && c==0)
                {
                    return "Vô số nghiệm";
                }
                if(b==0 && c !=0)
                {
                    return "Vô nghiệm";
                }
                return "x = "+ (-c*1.0 / b);
            }
            else
            {
                double delta = Math.Pow(b,2) - 4 * a * c;
                if (delta < 0)
                    return "Vô nghiệm";
                if (delta == 0)
                {
                    double x = -b / (2 * a);
                    return "nghiệm kép x1 = x2 = " + x;

                }
                else
                {
                    double x1 = (-b + Math.Sqrt(delta)) / (2*a);
                    double x2 = (-b - Math.Sqrt(delta)) / (2*a);
                    return "PT có 2 nghiệm phân biệt x1 = " +x1 + " x2 = " + x2;
                }
            }
        } 
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            string kq = GiaiPTBacHai(0,0,0);
            Console.WriteLine(kq);

            kq = GiaiPTBacHai(0, 0, 3);
            Console.WriteLine(kq);

            kq = GiaiPTBacHai(0, 8, 3);
            Console.WriteLine(kq);

            kq = GiaiPTBacHai(2, 5, -7);
            Console.WriteLine(kq);
            Console.ReadLine();
        }
    }
}
