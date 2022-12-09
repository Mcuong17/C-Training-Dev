using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai05
{
    internal class Program
    {
        /// <summary>
        /// Hàm này dùng để tính toán x, y, đây là comment hàm
        /// </summary>
        /// <param name="x">Nhập x kiểu int</param>
        /// <param name="y"> Nhập y kiểu int </param> 
        static void ham1(int x, int y)
        {

        }
        /// <summary>
        /// Đây là hàm tính tổng
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="z"></param>
        /// <returns></returns>
        static int Tong(int x, int y, int z)
        {
            return x + y + z;
        }
        static void Main(string[] args)
        {
            //commet một dòng
            /*
             Ghi
            chú
            nhiều dòng
             */
            ham1(4,5);
            Tong(1,2,3);
        }
    }
}
