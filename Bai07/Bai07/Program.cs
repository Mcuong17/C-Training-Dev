using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Bai07
{
    internal class Program
    {
        static void HocDoWWhile()
        {
            Console.WriteLine("Mời bạn nhập n: ");
            int n = int.Parse(Console.ReadLine());
            int gt = 1;
            int i = 1;
            do
            {
                gt *= i;
                i++;
            } while (i <= n);
            Console.WriteLine("Giai thừa của {0} là {1}", n, gt);

        }
        static void HocWhile()
        {
            Console.WriteLine("Mời bạn nhập n: ");
            int n = int.Parse(Console.ReadLine());
            int gt = 1;
            int i = 1;
            while( i <= n)
            {
                gt *= i;
                i++;
            }
            Console.WriteLine("{0}! = {1}", n,gt);
        }
        static void HocFor()
        {
            Console.WriteLine("Mời bạn nhập n: ");
            int n = int.Parse(Console.ReadLine());
            int gt = 1;
            for(int i = 1; i <= n; i++)
            {
                gt *= i;
            }
            Console.WriteLine("{0}! = {1}", n, gt);
        }
        static void toUpperChar()
        {
            string str = "abcd";
            string newCh = "";
            string ch = "";
            foreach(char c in str)
            {
                ch = char.ToUpper(c).ToString();
                newCh += ch;
            }
            Console.WriteLine(newCh);
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //HocDoWWhile();
            //HocWhile();
            //HocFor();
            toUpperChar();
            Console.ReadLine();
        }
    }
}
