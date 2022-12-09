using System;

namespace GiaiPTBac2
{
    class Program
    {
        static void PTBac2()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Nhập vào a");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhập vào b");
            float b = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhập vào c");
            float c = float.Parse(Console.ReadLine());
            float delTa, x, x1, x2;
            if(a == 0)
            {
                if(b == 0)
                {
                    Console.WriteLine("CT vô nghiệm");
                }
                else
                {
                    x = -c / a;

                    Console.WriteLine("CT có 1 nghiêm duy nhất " + x);
                }
            }
            else
            {
                delTa = (b * b) - (4 * a * c);
                if(delTa > 0)
                {
                    x1 = (float)(-b - Math.Sqrt(delTa)) / (2 * a);
                    x2 = (float)(-b + Math.Sqrt(delTa)) / (2 * a);

                    Console.WriteLine("CT có nghiệm phân biệt x1 = " + x1);
                    Console.WriteLine("CT có nghiệm phân biệt x2 = " + x2);
                }
                else if(delTa == 0)
                {
                    x1 = x2 = (-b) / (2 * a);

                    Console.WriteLine("CT có 1 nghiêm kép x1 = x2 = " + x1);
                }
                else
                {
                    Console.WriteLine("CT vô nghiệm");
                }
            }
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            PTBac2();
        }
    }
}
