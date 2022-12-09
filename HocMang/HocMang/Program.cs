using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HocMang
{
    internal class Program
    {
        /// <summary>
        /// Tạo mảng một chiều có n phần tử, sau đó:
        /// 1. Nhập các giá trị ngẫu nhiên cho các phần tử mảng M
        /// 2. Xuất các giá trị trong mảng M
        /// 3. Đảo ngược mảng
        /// 4. Sắp xếp mảng
        /// 5. Tìm kiếm mảng
        /// 6. Tính tổng các phần tử trong mảng
        /// </summary>
        static void HocMang1Chieu()
        {
            Console.WriteLine("Mời bạn nhập vào số phần tử trong mảng");
            int n = int.Parse(Console.ReadLine());
            int[] M = new int[n]; // mảng có n phần tử
            // 1. Nhập giá trị ngẫu nhiên cho mảng
            Random rand = new Random();// khai báo rand ngẫu nhiên
            for(int i = 0; i < M.Length; i++)
            {
                M[i] = rand.Next(100);
            }
            // Xuất các giá trị trong mảng
            Console.WriteLine("Mảng ngẫu nhiên là: ");
            for( int i = 0; i < M.Length; i++)
            {
                Console.Write(M[i] + " ");
            }
       
            // đảo ngược mảng
            Array.Reverse(M);
            Console.WriteLine("\nMang sau khi đảo chiều là");
            foreach(int i in M)
            {
                Console.Write(i + " ");
            }
            // sắp xếp mảng
            Array.Sort(M);
            Console.WriteLine("\nMảng được sắp xếp là: ");
            foreach( int i in M)
            {
                Console.Write(i + " ");
            }
            // tính tổng các phần tử trong mảng
            int sum = 0;
            foreach(int x in M)
            {
                sum+=x;
            }
            Console.WriteLine("\nTổng các phần tử trong mảng là: {0}", sum);
            // tìm kiếm mảng
            Console.WriteLine("\nNhập phần tử cần tìm");
            int viTri = int.Parse(Console.ReadLine());
            int kq = Array.BinarySearch(M, viTri);
            if (kq < 0)
            {
                Console.WriteLine("Không tìm thấy {0} trong mảng", viTri);
            }
            else
                Console.WriteLine("Tìm thấy {0} tại vị trí thứ {1}", viTri, kq);
            // tìm theo tuyến tính
            Console.WriteLine("\nNhập phần tử cần tìm tiếp theo");
            viTri = int.Parse(Console.ReadLine());
            kq = -1;
            for (int i = 0; i < M.Length; i++)
            {
                if (M[i] == viTri)
                {
                    kq = i;
                    break;
                } 
            }
            if (kq < 0 )
            {
                Console.WriteLine("Không tìm thấy {0} trong mảng", viTri);
            }
            else
                Console.WriteLine("Tìm thấy {0} tại vị trí thứ {1}", viTri, kq);
        }
        static void HocMang2Chieu()
        {
            Console.WriteLine("Nhập vào số dòng");
            int dong = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập vào số dòng");
            int cot = int.Parse(Console.ReadLine());
            int[,] M = new int[dong, cot];
            Random rd = new Random();
            for(int i = 0; i < M.GetLength(0); i++)
            {
                for(int j = 0; j < M.GetLength(1); j++)
                {
                    M[i, j] = rd.Next(100);
                }
            }
            Console.WriteLine("Mảng 2 chiều là");
            for(int i = 0; i < M.GetLength(0); i++)
            {
                for(int j = 0; j < M.GetLength(1); j++)
                {
                    Console.Write(M[i, j] + "\t");
                }
                Console.WriteLine("abc");
            }
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //HocMang1Chieu();
            HocMang2Chieu();
            Console.ReadLine();
        }
    }
}


/*
 
    - Khởi tạo mảng: mảng là một đối tượng -> cần cung cấp bộ nhớ cấp phát cho mảng
    - Cú pháp: tenMang = new KieuDuLieu[SoPhanTu];
    - Khởi tạo + gán: tenMang = newKieuDuLieu[SoPhanTu][gtri1, gtri2..]
    - Mảng là kiểu tham chiếu, gán mảng là gán tham chiếu, mảng A thay đổi -> giá trị thay đổi
    - Hàm trong mảng:
    + arr.CopyTo(mangA, 0): copy từ mảng cũ ra mảng A tính từ vị trí 0
    + Array.Copy(diem, mangA, diem.length): sao chép mảng diem -> mangA với số diem.length phần tử
    + Clone(int[], diem.Clone()): sao chép mảng diem qua mảng khác ô nhớ;
    + Array.Reverse(mang): Đảo ngược mảng;
    + Array.Sort(mang): sắp xếp các phần tử trong mảng;
    - Tìm kiếm mảng: có 2 cách:
    + Tìm kiếm đã sắp xếp: sử dụng tìm kiếm nhị phân: int viTri = Array.BinarySearch(mang)
        nếu có phần tử thì trả về 1, không có trả về -1
    + Mảng chưa sắp xếp: Thuật toán tìm kiếm tuyến tính: Xét phần tử đầu cho đến cuối một cách tuần tự
        Tại vị trí thứ i nếu gtri trong dữ liệu đúng với từ khóa được tìm kiếm -> tìm thấy
        Nếu không đúng tì tăng i+1. Tìm hết mà ko có gtri khóa cần tìm -> ko thấy
    - Mảng đa chiều:
    - Khai báo: Kiểu_dữ_lieu[ , ]mang = new Kiểu_dữ_liệu[so_hang, so_cot];
                VD: int[,]mang = new int[3,5];
    - Truy xuất: tenMang[vt dòng,vt cột];
    - Duyệt mảng 2 chiều:
        method: GetLength(0): chiều dài của dòng
                GetLength(1): chiều dài của cột
        Dùng 2 vòng for duyệt qua sẽ được các phần tử mong muốn
 */
