using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai08
{
    internal class Program
    {
        static int TinhGiaiThua(int n)
        {
            int gt = 1;
            for(int i = 1; i <= n; i++)
            {
                gt*= i;
            }
            return gt;
        }
        static string GiaiPhuongTrinhBac1(double a, double b)
        {
            if(a ==0 && b==0)
            {
                return "Vô số nghiệm";
            }
            if(a ==0 && b != 0)
            {
                return "PT vô nghiệm";
            }
            return "x = " + (-b / a);
        }
        static int Min(int a, int b) // tham số hình thức
        {
            return Math.Min(a, b);
        }
        static void fn1(int a)
        {
            a = a + 5;
            Console.WriteLine("a trong hàm fn1() = {0}", a);
        }
        static void fn2(ref int b)
        {
            b = b + 8;
            Console.WriteLine("b trong hàm: {0}", b);
        }
        static void fn3(out double c)
        {
            c = 8;
            c = c - 5;
            Console.WriteLine("c trong hàm: {0}", c);
        }
        static void GiaiPhuongTrinhBacHai(double a, double b, double c)
        {
            
            double delta = (b * b) - (4 * a * c);
            if(delta < 0)
            {
                Console.WriteLine("Phương trình vô nghiệm!") ;
            }
            if(delta == 0)
            {
                Console.WriteLine("Phương trình có nghiệm kép x1 = x2 = " + (-b) / (2 * a)) ;
            }
            if(delta > 0)
            {
                Console.WriteLine("Phương trình có 2 nghiệm phân biệt x1 = " + ((-b + Math.Sqrt(delta)) / 2 * a) + " x2 = " + ((-b - Math.Sqrt(delta)) / 2 * a));
            }
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            /*int a = 5;
            Console.WriteLine("a trước khi gọi hàm fn1() = {0}", a);
             fn1(a);
            Console.WriteLine("a sau khi gọi hàm fn1() = {0}", a); */

            /*int b = 10;
            Console.WriteLine("b là tham biến trước khi vào hàm: {0}", b);
            fn2(ref b);// với ref bắt buộc phải gán giá trị trước cho đối số
            Console.WriteLine("b là tham biến sau khi vào hàm: {0}", b);*/
            //double c;
            //fn3(out c); // với out thì không cần gán giá trị cho đối số trước
            //Console.WriteLine("c được truyền với out: {0}", c);

            Console.WriteLine("Mời bạn nhập a: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Mời bạn nhập b: ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Mời bạn nhập c: ");
            double c = double.Parse(Console.ReadLine());
             GiaiPhuongTrinhBacHai(a, b, c);
            //int kq = TinhGiaiThua(5);
            //Console.WriteLine("5! = {0}", kq);
            //string nghiem = GiaiPhuongTrinhBac1(3, 5);
            //Console.WriteLine(nghiem);
            //Console.WriteLine(Min(12, 36));// tham số thực
            Console.ReadLine();
        }
    }
}
