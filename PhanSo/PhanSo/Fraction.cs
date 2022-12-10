using System;
using System.Collections.Generic;
using System.Text;

namespace PhanSo
{
    class Fraction
    {
        private int tuSo;
        private int mauSo;

        // Contructor mặc định
        public Fraction()
        {
            this.tuSo = 0;
            this.mauSo = 0;
        
        }
        // Contrustor có đối số
        public Fraction(int tuso, int mauso, float phanso)
        {
            this.tuSo = tuso;
            this.mauSo = mauso;
        }
        // Các method get set của tử số và mẫu số
        public int TuSo
        {
            get
            {
                return tuSo;
            }
            set
            {
                tuSo = value;
            }
        }
        public int MauSo
        {
            get
            {
                return mauSo;
            }
            set
            {
                mauSo = value;
            }
        }
        // check phân số
        public bool validateFraction()
        {
            bool isFraction = true;
            if (tuSo == 0 || mauSo == 0)
            {
                isFraction = false;
            }
            return isFraction;
        }
        // Hàm nhập
        public void NhapPhanSo()
        {
            Console.WriteLine("Mời nhập tử số");
            this.tuSo = int.Parse(Console.ReadLine());
            Console.WriteLine("Mời nhập mẫu số");
            this.mauSo = int.Parse(Console.ReadLine());
            
                if(validateFraction())
                {
                    Console.WriteLine("Nhập thành công");
                }
               else
                {
                    Console.WriteLine("Nhập sai format");
                return;
                }
        }
        //In phân số
        public void InPhanSo()
        {
            if(validateFraction())
            {
            Console.WriteLine("Phân số vừa nhập: " + this.tuSo + "/" + this.mauSo);
            }
        }
        // hàm tính ước chung để rút gọn
        public int UCLN(int a, int b)
        {
            while(a != b)
            {
                if(a > b)
                {
                    a = a - b;
                }
                else
                {
                    b = b - a;
                }
            }
            return a;
        }
        public void RutGonPhanSo()
        {
            Fraction phanso = new Fraction();
            phanso.NhapPhanSo();
            int a = UCLN(phanso.tuSo, phanso.mauSo);
            if(a != 0)
            {
                if(a > 0)
                {
                    phanso.tuSo = phanso.tuSo / a;
                    phanso.mauSo = phanso.mauSo / a;
                }
                else
                {
                    phanso.tuSo = phanso.tuSo / (-a);
                    phanso.mauSo = phanso.mauSo / (-a);
                }
            }
            Console.WriteLine("Phân số sau khi rút gọn là: " + phanso.tuSo + "/" + phanso.mauSo);
        }
        public void NghichDaoPhanSo()
        {
            Fraction phanso = new Fraction();
            phanso.NhapPhanSo();
            Console.WriteLine("Phân số nghịch đảo của" + phanso.tuSo + "/" + phanso.mauSo + "là: " + phanso.mauSo + "/" + phanso.tuSo);
        }
        public void add(Fraction ps1, Fraction ps2)
        {
            Fraction psKq = new Fraction();
            Console.WriteLine("Nhập phân số thứ nhất: ");
            ps1.NhapPhanSo();
            Console.WriteLine("Nhập phân số thứ hai: ");
            ps2.NhapPhanSo();
            psKq.tuSo = ps1.tuSo * ps2.mauSo + ps2.tuSo * ps1.mauSo;
            psKq.mauSo = ps1.mauSo * ps2.mauSo;
            Console.WriteLine("Kết quả tổng hai phân số {0}", (psKq.tuSo/(float) psKq.mauSo));
        }
        public void sub(Fraction ps1, Fraction ps2)
        {
            Fraction psKq = new Fraction();
            Console.WriteLine("Nhập phân số thứ nhất: ");
            ps1.NhapPhanSo();
            Console.WriteLine("Nhập phân số thứ hai: ");
            ps2.NhapPhanSo();
            psKq.tuSo = ps1.tuSo * ps2.mauSo - ps2.tuSo * ps1.mauSo;
            psKq.mauSo = ps1.mauSo * ps2.mauSo;
            Console.WriteLine("Kết quả hiệu hai phân số {0}", (psKq.tuSo / (float)psKq.mauSo));
        }
        public void mul(Fraction ps1, Fraction ps2)
        {
            Fraction psKq = new Fraction();
            Console.WriteLine("Nhập phân số thứ nhất: ");
            ps1.NhapPhanSo();
            Console.WriteLine("Nhập phân số thứ hai: ");
            ps2.NhapPhanSo();
            psKq.tuSo = ps1.tuSo * ps2.tuSo;
            psKq.mauSo = ps1.mauSo * ps2.mauSo;
            Console.WriteLine("Kết quả tích hai phân số {0}", (psKq.tuSo / (float)psKq.mauSo));
        }

        public void div(Fraction ps1, Fraction ps2)
        {
            Fraction psKq = new Fraction();
            Console.WriteLine("Nhập phân số thứ nhất: ");
            ps1.NhapPhanSo();
            Console.WriteLine("Nhập phân số thứ hai: ");
            ps2.NhapPhanSo();
            psKq.tuSo =  ps1.tuSo * ps2.mauSo;
            psKq.mauSo = ps1.mauSo * ps2.tuSo;
            Console.WriteLine("Kết quả thương hai phân số {0}", (psKq.tuSo / (float)psKq.mauSo));
        }
    }
}
