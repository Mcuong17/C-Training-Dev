using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai12XuLyBietLe
{
    internal class Program
    {
        static void HocBietLe1()
        {
            Console.OutputEncoding = Encoding.UTF8;
            try
            {
                Console.WriteLine("Mời bạn nhập vào ngày tháng năm sinh");
                string s = Console.ReadLine();
                DateTime birthday = DateTime.Parse(s);
                Console.WriteLine("Bạn vừa nhập năm sinh " + birthday.ToString("dd/MM/yyyy"));

            }
            catch (Exception ex)// thông báo lỗi, lỗi sẽ chạy vào đây
            {
                Console.WriteLine(ex.Message);
            }
            finally //thường dùng để đóng kết nối csdl
            {
                Console.WriteLine("Lỗi hay không cũng vào đây");
            }
            Console.ReadLine();
        }
        static void HocBietLe2()
        {
                Console.OutputEncoding = Encoding.UTF8;
                Console.WriteLine("Mời bạn nhập tử số");
                int tuSo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Mời bạn nhập mẫu số");
                int mauSo = Convert.ToInt32(Console.ReadLine());
                if( mauSo == 0)
                {
                throw new ArithmeticException("Lỗi mẫu số bằng 0"); 
                }
        }

        
        static void Main(string[] args)
        {
           
            try
            {
                HocBietLe2();
            }
            catch (ArithmeticException ex) // xử lý khi bị lỗi
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
