using System;

namespace PhanSo
{
    class Program
    {
        
        static void menu()
        {
            Console.WriteLine("******************************************");
            Console.WriteLine("* Chương trình tính toán phân số         *");
            Console.WriteLine("* Mời chọn chức năng:                    *");
            Console.WriteLine("* 1. Nhập vào phân số và in ra phân số   *");
            Console.WriteLine("* 2. Rút gọn phân số                     *");
            Console.WriteLine("* 3. Đảo ngược phân số                   *");
            Console.WriteLine("* 4. Cộng hai phân số                    *");
            Console.WriteLine("* 5. Trừ hai phân số                     *");
            Console.WriteLine("* 6. Nhân hai phân số                    *");
            Console.WriteLine("* 7. Chia hai phân số                    *");
            Console.WriteLine("******************************************");
            try
            {

                int chucNang = int.Parse(Console.ReadLine());
                Fraction phanso = new Fraction();
                Fraction phanso1 = new Fraction();
                Fraction phanso2 = new Fraction();
                switch (chucNang)
                {
                    case 1:
                        phanso.NhapPhanSo();
                        phanso.InPhanSo();
                        break;
                    case 2:
                        Console.WriteLine("Nhập phân số muốn rút gọn");
                        phanso.RutGonPhanSo();
                        break;
                    case 3:
                        Console.WriteLine("Nhập phân số muốn đảo ngược");
                        phanso.NghichDaoPhanSo();
                        break;
                    case 4:
                        phanso.add(phanso1,phanso2);
                        break;
                    case 5:
                        phanso.sub(phanso1, phanso2);
                        break;
                    case 6:
                        phanso.mul(phanso1, phanso2);
                        break;
                    case 7:
                        phanso.div(phanso1, phanso2);
                        break;
                    default:
                        Console.WriteLine("Không có chức năng này");
                        break;
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Lỗi gì đó " + ex);
            }
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            
            while (true)
            {
                menu();
                Console.WriteLine("Bạn có muốn tiếp tục(y/n)");
                string luachon = Console.ReadLine();
                if (luachon == "n")
                {
                    break;
                }
            }
            Console.WriteLine("Baiii Baii");
            Console.ReadLine();

        }
    }
}
