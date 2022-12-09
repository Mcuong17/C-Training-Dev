using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HocList
{
    internal class Program
    {
        // 1. Khai báo một list
        // 2. Thêm một phần tử vào danh sách
        // 3. Chèn một phần tử vào danh sánh
        // 4. Xóa một phần tử khỏi danh sách
        // 5. Thêm nhiều phần tử vào danh sách
        // 6. Xóa nhiều phần tử khỏi danh sách
        static void HocList()
        {
            // cấp phát bộ nhớ để sử dụng
            List<String> ds = new List<String>();
            // Thêm một phần tử vào danh sách
            ds.Add("an");
            ds.Add("Bình");
            ds.Add("hạnh");
            ds.Add("phúc");
            // Chèn một phần tử
            ds.Insert(2, "Giải thoát");
            // Xóa một phần tử
            ds.Remove("Bình");
            ds.RemoveAt(0);
            Console.WriteLine("Danh sách các phần tử trong list: ");
            for( int i = 0; i < ds.Count; i++ )
            {
                String v = ds[i];
                Console.WriteLine(v);
            }
        }
        static void HocList2()
        {
            List<int> ds = new List<int>();
            Random rnd = new Random();
            for(int i = 0; i< 10; i++)
            {
                ds.Add(rnd.Next(100));
            }
            Console.WriteLine("Các phần tử trong danh sách gốc là");
            foreach (int i in ds)
                Console.Write(i + "\t");
            ds.Sort();
            Console.WriteLine("\nCác phần tử trong danh sách gốc được sắp xếp là");
            foreach(int i in ds)
            {
                Console.Write(i + "\t");
            }
            Console.WriteLine("\nMời bạn nhập vào số muốn tìm");
            int k = int.Parse(Console.ReadLine());
            int kq = ds.IndexOf(k);
            if(kq > 0)
            {
                Console.WriteLine("Tìm thấy {0} tại vị trí {1}", k, kq);
            }
            else
            {
                Console.WriteLine("Không tìm thấy {0} trong danh sách", k);
            }
        }
        static void THList()
        {
            List<int> ds = new List<int>();
            Random rd = new Random();
            Console.WriteLine("Bạn muốn nhập bao nhiêu phần tử?");
            int n = int.Parse(Console.ReadLine());
            for(int i = 0; i< n;i++)
            {
                ds.Add(rd.Next(100));
            }
            Console.WriteLine("Danh sách vừa tạo là: ");
            foreach(int i in ds)
            {
                Console.Write(i + "\t");
            }
            ds.Sort();
            Console.WriteLine("\nDanh sách được sắp xếp là: ");
            foreach (int i in ds)
            {
                Console.Write(i + "\t");
            }
            Console.WriteLine("\nBạn muốn xóa phần tử thứ mấy?");
            int xoa = int.Parse(Console.ReadLine());
            if(xoa <= n)
            {
                ds.RemoveAt(xoa);
                Console.WriteLine("\n Danh sách sau khi xóa phần tử thứ {0} là", xoa);
                foreach (int i in ds)
                {
                    Console.Write(i + "\t");
                }
            }
            else
            {
                Console.WriteLine("Không có phần tử bạn muốn xóa");
            }
            Console.WriteLine("\nBạn muốn chèn gì");
            int chen = int.Parse(Console.ReadLine());
            Console.WriteLine("\nBạn muốn chèn vào vị trí nào");
            int vitri = int.Parse(Console.ReadLine());
            if(vitri <= n)
            {
                ds.Insert(vitri+1, chen);
                Console.WriteLine("\nDanh sách sau khi chèn {0} là", chen);
                foreach (int i in ds)
                {
                    Console.Write(i + "\t");
                }
            }
            else
            {
                Console.WriteLine("Không thể chèn quá phần tử");
            }
            
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //HocList();
            //HocList2();
            THList();
            Console.ReadLine();
        }
    }
}

/*
    -List: là một lựa chọn thay thế cho mảng như một danh sách liên kết
    - Khai báo List: List<Kiểu_dữ_liệu> list = new List<Kiểu_dữ_liệu>();
    - Các method của List:
    + list.Add(pt): thêm phần tử
    + list.Remove(pt): xóa phần tử
    + list.Count: số lượng phần tử trongn List
    + list.Clear(): xóa toàn bộ
    + list.addRange(ICollection c): Thêm một tập vào List
    + bool Contains(object item): Kiểm tra phần tử có trong danh sách hay không
    + List GetRange(int index, int count): lấy một tập dữ liệu con có trong ds list gốc
    + int IndexOf(object): trả về chỉ mục của phần tử đầu tiên tìm thấy
    + void Insert(vị trí, giá trị): chèn 1 phần tử tại vị trí đã định
    + void InsertRange(vị trí, danh sách): chèn một danh sách các phần tử vào vị trí chỉ định
    + void RemoveAt(vị trí): Xóa bỏ theo vị trí muốn
    + void RemoveRange(vị trí, số lượng): Xóa bỏ một tập danh sách trong list
    + void Reverse(): Đảo ngược
    + void SetRange(vị trí, tập danh sách): Sao chép các phần tử của một tập danh sách qua một tập khác trong List
    + void Sort(): Sắp xếp các phần tử trong list
    + void TrimExcess(): thiết lập capacity tới số phần tử thực sự trong list

 
 */